using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //CarManagerTest(); Bu method carManager için yazılmış olan bir testtir.
        //UserManagerTest(); Bu method UserManager için yazılmış testtir.



        CarManager carManager = new CarManager(new EfCarDal());

        foreach (var car in carManager.GetCarDetails())
        {
            Console.WriteLine(car.CarId+" : "+ car.BrandName + " " + car.ColorName);
            

        }



        /* Brand brand = new Brand();
         brand.BrandName = "Mercedes";
         BrandManager brandManager = new BrandManager(new EfBrandDal());
         brandManager.Add(brand);
         */
    }

    private static void UserManagerTest()
    {
        UserManager userManager = new UserManager(new EfUserDal());


        foreach (var user in userManager.GetAll())
        {
            Console.WriteLine(user.UserId + "-)" + user.FirstName + " " + user.LastName);
            Console.WriteLine("Kullanıcı E-Maili : " + user.Email);
            Console.WriteLine("Kullanıcı Şifresi : " + user.Password);

        }
    }

    private static void CarManagerTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.CarId + "-)" + car.Description + car.ModelYear + car.DailyPrice);

        }

        foreach (var getByBrandId in carManager.GetCarsByBrandId(1))
        {
            Console.WriteLine(getByBrandId.Description);
        }

        foreach (var getByColorId in carManager.GetCarsByColorId(1))
        {
            Console.WriteLine(getByColorId.Description);
        }
        foreach (var getByCarId in carManager.GetCarsById(2))
        {
            Console.WriteLine(getByCarId.Description);
        }

    }
}