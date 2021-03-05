using System;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //классы
        //
        //Продукты
        class Product
        {
            int productId;
            string productName;
            int productCost;
            int productCountInStorage;
            TypeProduct productType;

            public Product(int id, string name, int cost, int count, Storage storage, TypeProduct type)
            {
                this.productId = id;
                this.productName = name;
                this.productCost = cost;
                this.productCountInStorage = count;
                this.productStorage = storage;
                this.productType = type;
            }
            public void BuyProduct(int count, int cost) { }
            public void DeliveryProduct(int count, Storage productStorage) 
            {
                if (productStorage == IProductCount.productStorage)
                {
                    IProductCount.productCount = count;
                }
                
            }
        }
        //Привозчики
        class ImportOrganization
        {
            int orgId;
            string orgName;
            int orgInn;
            string orgDirector;

            public ImportOrganization(int id, string name, int inn, string director)
            {
                this.orgId = id;
                this.orgName = name;
                this.orgInn = inn;
                this.orgDirector = director;
            }
            public void ChangeTheData() { }
        }
        //Сотрудники
        class Worker
        {
            WorkerData employee;

            public Worker(string name, int salary, int snils, DateTime birthday, string post)
            {
                employee.workerName = name;
                employee.workerPost = post;
                employee.workerBirthday = birthday;
                employee.workerSnils = snils;
                employee.workerSalary = salary;
            }
            public void ChangeData(WorkerData employee2)
            {
                employee.ChangeData(employee2);
            }
        }
        //Заказ (общий)
        class Order
        {
            int ordId;
            WorkerData ordCashier;
            int ordSum;
            int ordCount;

            public Order(int id, WorkerData employee, int sum)
            {
                this.ordId = id;
                this.ordCashier = employee;
                this.ordSum = sum;
            }
            public void AddOrderInterface()
            {
                IOrder.orderCount++;
                IOrder.orderProceeds += ordSum;
                IOrder.orderProductSaled += ordCount;
            }
        }
        //Содержимое заказа
        class OrderContent : Order
        {
            int orderId;
            int product;
            int price;
            int count;
            int sum;
            //Добавление продукта в заказ
            public OrderContent(int id, WorkerData employee, int sum, int product, int price, int count) : base(id, employee, sum)
            {
                this.orderId = id;
                this.product = product;
                this.price = price;
                this.count = count;
                this.sum = price * count;
            }
        }


        //структуры
        //
        //вся информация о сотрудниках
        struct WorkerData
        {
            public string workerName;
            public int workerSalary;
            public int workerSnils;
            public DateTime workerBirthday;
            public string workerPost;
            
            public void ChangeData(WorkerData worker)
            {
                this.workerName = worker.workerName;
                this.workerSalary = worker.workerSalary;
                this.workerSnils = worker.workerSnils;
                this.workerPost = worker.workerPost;
                this.workerBirthday = worker.workerBirthday;
            }
        }
        //Отработано часов
        struct Atttndance
        {
            WorkerData employee;
            Mounth mounth;
            int hours;
        }


        //Интерфейсы
        //
        //интерфейс, считывающий количество проданной продукции, количество заказов и выручки
        interface IOrder
        {
            static int orderCount;
            static int orderProceeds;
            static int orderProductSaled;
        }
        //количество продуктов на складах
        interface IProductCount
        {
            static int productCount;
            static Storage productStorage;
        }


        //Перечисления
        //
        //типы продуктов
        public enum TypeProduct
        {
            Овощи,
            Фрукты,
            Другое
        }
        //склады продуктов
        public enum Storage
        {
            Основной,
            Дополнительный
        }
        //название месяцев
        public enum Mounth
        {
            Январь = 1, Февраль = 2, Март = 3, Апрель = 4, Май = 5, Июнь = 6, 
            Июль = 7, Август = 8, Сентябрь = 9, Октябрь = 10, Ноябрь = 11, Декабрь = 12
        }
    }
}
