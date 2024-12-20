using System.Net.Http.Headers;

namespace OOP_Car
{
    class Car
    {
        public Car()
        {

        }
        public Car(string model, int year, decimal price, decimal carSpeed)
        {
            Model = model;
            Year = year;
            Price = price;
            Speed = carSpeed;
        }
        public string Model { get; set; }
        public decimal Price { get; set; }
        private int year;
        public int Year //logikasi to'g'ri bo'lmasligi mumkin(propertiylarni sinab ko'rish uchun qilindi)
        {
            get { return year; }
            set
            {
                if (value < 1950) // mashina yili 1950 dan kam bo'lsa 1950 ni oladi 
                    year = 1950;
                else if (1950 <= value && value <= DateTime.Now.Year) // 1950 dan hozirgin kungacha berilgan yilni oladi
                    year = value;
                else        // hozirgi yildan yuqorilarini hozirgi yil bilan oladi
                    year = DateTime.Now.Year;
            }
        }

        private decimal speed;
        public decimal Speed //logikasi to'g'ri bo'lmasligi mumkin(propertiylarni sinab ko'rish uchun qilindi)
        {
            get { return speed; }
            set
            {
                if (value < 0)        // Tezlik manfiy bo'lsa, 0 o'rnatiladi
                    speed = 0;
                else if (value > 500) // Tezlik 500 dan katta bo'lsa, 500 o'rnatiladi
                    speed = 500;
                else
                    speed = value;    // Aks holda berilgan qiymat o'rnatiladi

            }
        }

        public string GetCarInfo()
        {
            return $"Model: {Model}\nYear: {Year}\nPrice: {Price} so'm\nSpeed: {Speed} km/soat";
        }
        public decimal CalculateDepreciation(int years)
        {
            if (years <= Year) // hali chiqmagan yoki o'sha yili chiqqan mashina narxi o'zgarmaydi
                return Price;
            decimal price = Price;
            for (int eachYear = 1; eachYear <= years - Year; eachYear++)
            {
                price = price * (decimal)0.9;
            }
            return price;
        }
    }
}