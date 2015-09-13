# Abstract Factory
___

## ��� �� ������� �� ������:
Abstract factory pattern

## ������ ��������:
�������� �� ������ "Abstract Factory" ������� ��������� �� �������, ����� ����������� ��� �������� �������.

## ���� �� ��������:
1/5

## UML ������� ��������:
![Abstract Factory UML Class Diagram](http://download.codeplex.com/download?ProjectName=csharpdesignpatterns&DownloadId=236763 "Abstract Factory UML Class Diagram")

## �������� ���������
+ ������ Abstract Factory �������� ����������� ���������� ������, ����� ������ �� ����� �������������� �� ����������� factory �������. ��� ��������� ������ �� ��������� � ��������� �� ��������.
+ ����������� factory ������� �������� � ���� �� �������� ������������� �� ���������, ����� ����� ��������� �� ����� �� ���������� �� ����������.
+ ����� � �� �� ��������, �� ��������, ����� ������ ��������, ���� �� ���������� �� ���������� �������, ����� �� ���� ������ ��������� ������ ��������� � ������������, ������� �� ������, ����� ������ �� ����� �������������� ���� ������.
+ ��������� ������� ����� �� ���������� �� ����� ��������� factory ���� (��. ��������������� ��-����).

```cs
public abstract class CarFactory
    {
        public abstract SportsCar CreateSportsCar();
        public abstract FamilyCar CreateFamilyCar();
    }
 
    public class AudiFactory : CarFactory
    {
        public override SportsCar CreateSportsCar()
        {
            return new AudiSportsCar();
        }
 
        public override FamilyCar CreateFamilyCar()
        {
            return new AudiFamilyCar();
        }
    }
 
    public class MercedesFactory : CarFactory
    {
        public override SportsCar CreateSportsCar()
        {
            return new MercedesSportsCar();
        }
 
        public override FamilyCar CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }
    }
```

+ ��� ���� �� ������ ������������ �������, ����� �� ��������� �� ����� �� ������� �� ����������� �� ������ �������.
+ ��������� ����� ������������ �������, �� �������� ������ �������� �������, ����� ����� ������������ �� ����� �� ���������� �� ���������� � ���������� �� ����������� factory �������, ����� �� ��������.

```cs
    public abstract class SportsCar
    {
    }
 
    public abstract class FamilyCar
    {
        public abstract void Speed(SportsCar abstractFamilyCar);
    }
 
    class MercedesSportsCar : SportsCar
    {
    }
    
    class MercedesFamilyCar : FamilyCar
    {
        public override void Speed(SportsCar abstractSportsCar)
        {
            Console.WriteLine(GetType().Name + " is slower than "
                + abstractSportsCar.GetType().Name);
        }
    }
 
    class AudiSportsCar : SportsCar
    {
    }
 
    class AudiFamilyCar : FamilyCar
    {
        public override void Speed(SportsCar abstractSportsCar)
        {
            Console.WriteLine(GetType().Name + " is slower than "
                + abstractSportsCar.GetType().Name);
        }
    }
```

+ ��� ��������������� �� ����������� �� ����� Driver ������������ factory ���� � ������������ ������� ���� �� ���� ��������� ����������� �� ����� C# ���������� ������ ���� ���������� ���������� �� ������ �������-����������, ����� �� ���� ������ � ���-��������� ����� �� ���������� �� �����.

```cs
	public class Driver
    {
        private SportsCar _sportsCar;
        private FamilyCar _familyCar;
 
        public Driver(CarFactory carFactory)
        {
            _sportsCar = carFactory.CreateSportsCar();
            _familyCar = carFactory.CreateFamilyCar();
        }
 
        public void CompareSpeed()
        {
            _familyCar.Speed(_sportsCar);
        }
    }
```

+ �������� � � ���� ������, ���������� �� ����� C#, � ������ ������, ��� ����� ������ � ������ � ������ ��������. ���� ��������� ���������� �� ������������ ������ ��� ������ ��� ������� �� �������� �������-����������, �� ���� �� �� ����� ��������� (���� � ���� �� ��������, ����� �� �������� ���� ������������� ���������� ��� ���������� �� ������� ��������).

```cs
	public class Driver
    {
        private CarFactory _carFactory;
        private SportsCar _sportsCar;
        private FamilyCar _familyCar;
 
        public Driver(CarFactory carFactory)
        {
            CarFactory = carFactory;
            SportsCar = CarFactory.CreateSportsCar();
            FamilyCar = CarFactory.CreateFamilyCar();
        }
 
        private CarFactory CarFactory
        {
            get { return _carFactory; }
            set { _carFactory = value; } 
        }
 
        private SportsCar SportsCar
        {
            get { return _sportsCar; }
            set { _sportsCar = value; } 
        }
 
        private FamilyCar FamilyCar
        {
            get { return _familyCar; }
            set { _familyCar = value; } 
        }
 
        public void CompareSpeed()
        {
            FamilyCar.Speed(SportsCar);
        }
    }
```

+ ���� ����� ������ ������ ��� ����� C# � ������������ �� �������� ������� �� ��������� �� ������.

```cs
	public class GenericFactory<T> 
        where T : new()
    {
        public T CreateObject()
        {
            return new T();
        }
    }
```

+ ��� ���������� ������ �������� ����� ���, �� �� �������� ������� � ������ ������������� �� �������.

```cs
	public static void AbstractFactory()
    {
        // Language agnostic version
        CarFactory audiFactory = new AudiFactory();
        Driver driver1 = new Driver(audiFactory);
        driver1.CompareSpeed(); ;
 
        CarFactory mercedesFactory = new MercedesFactory();
        Driver driver2 = new Driver(mercedesFactory);
        driver2.CompareSpeed();
 
        // C# specific version using generics
        var factory = new GenericFactory<MercedesSportsCar>();
        var mercedesSportsCar = factory.CreateObject();
        Console.WriteLine(mercedesSportsCar.GetType().ToString());
 
        Console.ReadKey();
    }
```