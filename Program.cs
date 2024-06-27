namespace Lesson
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Выведите платёжные ссылки для трёх разных систем платежа: 
            //pay.system1.ru/order?amount=12000RUB&hash={MD5 хеш ID заказа}
            //order.system2.ru/pay?hash={MD5 хеш ID заказа + сумма заказа}
            //system3.com/pay?amount=12000&curency=RUB&hash={SHA-1 хеш сумма заказа + ID заказа + секретный ключ от системы}

            var order = new Order(101, 12000);

            var paymentSystems = new List<PaymentSystem>()
            {
                new PaymentSystem(new System1LinkFormatter("pay.system1.ru/order?amount={0}&hash={1}", "RUB"), new HashGeneratorById(new MD5HashService())),
                new PaymentSystem(new System2LinkFormatter("order.system2.ru/pay?hash={0}"), new HashGeneratorByIdAndAmount(new MD5HashService())),
                new PaymentSystem(new System3LinkFormatter("system3.com/pay?amount={0}&curency={1}&hash={2}", "RUB"), new HashGeneratorByIdAndAmountWithSecurity(new Sha1HashService())),
            };

            foreach (var paymentSystem in paymentSystems)
            {
                Console.WriteLine($"Paylink: {paymentSystem.GetPayingLink(order)}");
            }
        }
    }
}