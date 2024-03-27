const {Client} = require('pg')
const fs = require('fs');
const { log } = require('console');

 
  async function client() {
    const client = new Client({
      host: "localhost",
      user: "postgres",
      port: 5432,
      password: "1234",
      database: "Credit_DB"
     })
     try {

      await client.connect();
     
     // SELECT amount_credit, interest_rate, loan_term FROM loan_application WHERE client_id = ${idClient}`;
     
     // определяем переменную id клиента для которого хотим рассчитать график аннуитетных платежей
      const idClient = 3
      const queryText = `SELECT * 
                         FROM client
                         JOIN loan_application ON client.client_id = loan_application.client_id
                         WHERE client.client_id = ${idClient}`;
      const result = await client.query(queryText);
      // Вызываем функцию processQueryResult с результатами запроса
      let valueCredit1 = { }
      valueCredit1 = processQueryResult(result)
        return await valueCredit1;
    

      } catch (err) {
        console.error('Error executing query:', err)
        throw err
    } finally {
        await client.end();
    }
  }
 
 
  async function processQueryResult(res) {
     
        if (res.rows.length > 0) {
          const valueCredit = {
            last_name: res.rows[0].last_name,
            first_name: res.rows[0].first_name,
            middle_name: res.rows[0].middle_name,
            amountCredit: +res.rows[0].amount_credit,
            interestRate: +res.rows[0].interest_rate,
            loanTerm: +res.rows[0].loan_term
          };
           return await valueCredit;
        } else {
          console.log('Данные не найдены.');
        }
    
  };
  async function fileName(valueCredit) {
    
    const text=`Платеж_${valueCredit.last_name}_${valueCredit.first_name}_${valueCredit.middle_name}.txt`;
  return await text
  }
//function scheduleAnnuityPayment(sumCredit, rateCredit, numberМonth, outputFileName ) valueCredit
async function scheduleAnnuityPayment(valueCredit) {
  
  let sumCredit = valueCredit.amountCredit
  const rateCredit = valueCredit.interestRate
  const numberМonth = valueCredit.loanTerm
  const month = 12

  // Преобразуем годовую процентную ставку в месячную и делим на 100
  const monthlyRateCredit = (rateCredit / month) / 100;

  // Рассчитываем аннуитетный платеж
  const annuityPayment = sumCredit * (monthlyRateCredit * Math.pow(1 + monthlyRateCredit, numberМonth)) / (Math.pow(1 + monthlyRateCredit, numberМonth) - 1);
         
  let annuityPaymentSchedule = [];
  
  for (let month = 1; month <= numberМonth; month++) {
    const interestPayment = sumCredit * monthlyRateCredit; // долг по процентам
    const principalPayment = annuityPayment - interestPayment; // основной долг
    sumCredit -= principalPayment; // остаток основного долга

  annuityPaymentSchedule.push({
      month,
      annuityPayment: annuityPayment.toFixed(2),
      principalPayment: principalPayment.toFixed(2),
      interestPayment: interestPayment.toFixed(2),
      sumCredit: sumCredit.toFixed(2)
    });
  }
  return await annuityPaymentSchedule;
    //return annuityPaymentSchedule;
}

async  function writeScheduleToTextFile(valueCredit, schedule, fileName) {
  
    const header = `Расчет аннуитетного платежа для клиента: ${valueCredit.last_name} ${valueCredit.first_name} ${valueCredit.middle_name}
                  \nСумма кредита:  ${valueCredit.amountCredit} руб. \nПроцентная ставка: ${valueCredit.interestRate}% \nСрок: ${valueCredit.loanTerm} месяцев 
                  \n | Месяц | \t Аннуитетный платеж | \tОсновной долг | \tДолг по процентам | \tОстаток основного долга |\n`;
    let table = header;

    schedule.forEach(entry => {
      table += `\t${ entry.month.toString().padEnd(6)} \t\t ${entry.annuityPayment.toString().padEnd(13)} \t\t ${entry.principalPayment.toString().padEnd(15)} \t\t ${entry.interestPayment.toString().padEnd(15)} \t\t ${ entry.sumCredit.toString().padEnd(1)}\n`;
    });

    fs.writeFileSync(fileName, table, 'utf-8');
    console.log(`График аннуитетных платежей успешно записан в файл: ${fileName}`);
}

 async function go() {
  
  try {
      const valueCredit = await client();
      const fileName1 = await fileName(valueCredit);
      const schedule = await scheduleAnnuityPayment(valueCredit);      
      await writeScheduleToTextFile(valueCredit, schedule, fileName1);
  } catch (error) {
      console.error('An error occurred:', error);
  }
}
go()