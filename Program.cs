internal class Program
{
    private static void Main(string[] args)
    {
        #region Double Değişkenler.
        //double number;

        //number = 4.90;
        //Console.WriteLine(number);



        //Console.WriteLine("********* Fiyat Listesi *******");
        //Console.WriteLine();


        //double applePrice, orangePrice, strawberyyPrice, tomatoPrice, potatoPrice;
        //applePrice = 10.53;
        //orangePrice = 4.56;
        //strawberyyPrice = 20.30;
        //tomatoPrice = 5.60;
        //potatoPrice = 4.50;

        //Console.WriteLine("--- Elma Birim Fiyatı :" + applePrice+ " TL");
        //Console.WriteLine("--- Portakal Birim Fiyatı :" + orangePrice+ " TL");
        //Console.WriteLine("--- Çilek Birim Fiyatı :" + strawberyyPrice+ " TL");
        //Console.WriteLine("--- Domates Birim Fiyatı :" + tomatoPrice+ " TL");
        //Console.WriteLine("--- Patates Birim Fiyatı :" + potatoPrice+ " TL");

        //Console.WriteLine(); // satır atlamak için.
        //Console.WriteLine();

        //double appleGram, orangeGram, strawberyyGram, tomatoGram, potatoGram;
        //appleGram = 1.245;
        //orangeGram = 2.434;
        //strawberyyGram = 0.520;
        //tomatoGram = 3.451;
        //potatoGram = 2.345;


        //double appleTotalPrice, orangeTotalPrice, strawberTotalPrice, tomatoTotalPrice, potatoTotalPrice;
        //appleTotalPrice = appleGram * applePrice;
        //orangeTotalPrice = orangeGram * orangePrice;
        //strawberTotalPrice = strawberyyGram * strawberyyPrice;
        //tomatoTotalPrice = tomatoGram * tomatoPrice;
        //potatoTotalPrice = potatoGram * potatoPrice;

        //Console.WriteLine("Alınan ürün:Elma - " +  " Birim fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam fiyat: "  + appleTotalPrice);

        //Console.WriteLine();

        //double shoppingTotalPrice = appleTotalPrice  + orangeTotalPrice + strawberTotalPrice + tomatoTotalPrice + potatoTotalPrice;
        //Console.WriteLine("Alışveriş Toplam fiyatı:" + shoppingTotalPrice);

        #endregion

        #region Char Değişkenler.

        // char değişkenler tek tırnakla tanımlanır.

        //char symbol;
        //symbol = 'a';
        //Console.WriteLine(symbol);




        #endregion

        #region Klavyeden veri girişleri Str değişken

        //Console.WriteLine("******** CSharp Hava Yolları Yolcu Bilgisi ");
        //Console.WriteLine();

        //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge,
        //passangerIdentyNumber;

        //Console.Write("Yolcu adı: ");
        //passangerName = Console.ReadLine();

        //Console.Write("Yolcu soyadı: ");
        //passangerSurname = Console.ReadLine();


        //Console.Write("İlçe Bilgisi: ");
        //passangerDistrict = Console.ReadLine();

        //Console.Write("Şehir Bilgisi: ");
        //passangerCity = Console.ReadLine();

        //Console.Write("Yolcu Yaşı: ");
        //passangerAge = Console.ReadLine();

        //Console.Write("Yolcu kimlik numarası: ");
        //passangerIdentyNumber = Console.ReadLine();


        //Console.WriteLine();

        //Console.WriteLine("------------");
        //Console.WriteLine("Yolcu: " + passangerName + " " + passangerSurname + " " + passangerDistrict + " " + passangerCity  + " " + 
        //    passangerAge + " " + " YOLCU TC NO: "  + " " + passangerIdentyNumber);

        #endregion

        #region Klavyeden Tam sayı girişleri ve Dönüşümler

        //int shoePrice, computerPrice, chairPrice, tvPrice;
        //shoePrice = 2000;
        //computerPrice = 12000;
        //chairPrice = 5000;
        //tvPrice = 12450;


        //int shoeCount, computerCount, chairCount, tvCount;

        //Console.Write("Lütfen aldığınız ayakkabı sayısını girin: ");
        //shoeCount = int.Parse(Console.ReadLine());

        //Console.Write("Aldığınız bilgisayar sayısını giriniz: ");
        //computerCount = int.Parse(Console.ReadLine());


        //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
        //chairCount = int.Parse(Console.ReadLine());

        //Console.Write("Lütfen aldığınız Tv sayısını giriniz: ");
        //tvCount = int.Parse(Console.ReadLine());



        //int totalPrice = shoeCount * shoePrice +  computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

        //Console.WriteLine();
        //Console.WriteLine("Toplam Ödemeniz gereken Tutar: " + totalPrice);

        #endregion

        #region Klavyeden Ondalıklı sayı işlemleri

        //double exam1,exam2 ,exam3,result;
        //Console.Write("Lütfen 1.Sınav sonucu giriniz: ");
        //exam1 = double.Parse(Console.ReadLine());
        //Console.Write("Lütfen 2.Sınav sonucu giriniz: ");
        //exam2 = double.Parse(Console.ReadLine());
        //Console.Write("Lütfen 3.Sınav sonucu giriniz: ");
        //exam3 = double.Parse(Console.ReadLine());

        //result = (exam1 + exam2 + exam3 ) / 3 ;

        //Console.WriteLine();
        //Console.WriteLine("Sınav Ortalamaınız:  " + result);

        #endregion

        #region Klavyeden Karakter Girişleri

        //char gender;
        //Console.Write("Lütfen cinsiye seçiniz: ");
        //gender = char.Parse(Console.ReadLine());

        //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

        #endregion

        Console.Read();


    }
}