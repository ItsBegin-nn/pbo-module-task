class Item
{
    public string judul { get; set; }
    public int tahun {  get; set; }

    public virtual void Deskripsi()
    {
        Console.WriteLine($"judul = {judul}, dibuat tahun {tahun}");
    }

    public void InfoItem()
    {
        Deskripsi();
    }
}

class Buku : Item
{
    public string penulis { get; set; }
    
    public void CekPenulis()
    {
        Console.WriteLine($"Penulis buku '{judul}' adalah: {penulis}");
    }

    public override void Deskripsi() 
    {
        Console.WriteLine($"Judul Buku: {judul}, Tahun: {tahun}, Penulis: {penulis}");   
    }

}

class Majalah : Item
{
    public int edisi;

    public void Infoedisi()
    {
        Console.WriteLine($"judul = {judul}, dibuat tahun {tahun}, edisi {edisi}");
    }

    public override void Deskripsi()
    {
        Console.WriteLine($"Judul Majalah: {judul}, Tahun: {tahun}, edisi {edisi}");
    }

}

class Novel : Buku
{
    public void BacaSinopsis()
    {
        Console.WriteLine($"membaca sinopsis Novel : {judul}, Karya {penulis}");
    }

    public override void Deskripsi()
    {
        Console.WriteLine($"Judul Novel: {judul}, Tahun: {tahun}, Penulis: {penulis}");
    }
}

class Komik : Buku
{
    public void TampilkanIlustrasi()
    {
        Console.WriteLine($"ini ilustrasi Komik {judul}, karya {penulis}");
    }

    public override void Deskripsi()
    {
        Console.WriteLine($"Judul Komik: {judul}, Tahun: {tahun}, Penulis: {penulis}");
    }
}

class MajalahAnak : Majalah
{
    public void KategoriAnak()
    {
        Console.WriteLine($"{judul} edisi ke-{edisi} termasuk majalah anak");
    }
    public override void Deskripsi()
    {
        Console.WriteLine($"Judul Majalah Anak: {judul}, Tahun: {tahun}, edisi {edisi}");
    }
}

class MajalahTeknologi : Majalah
{
    public void TopikTeknologi()
    {
        Console.WriteLine($"majalah {judul} edisi-{edisi} sedang membahas perkembangan teknoligi zaman sekarang");
    }
    public override void Deskripsi()
    {
        Console.WriteLine($"Judul Majalah Teknologi: {judul}, Tahun: {tahun}, edisi {edisi}");
    }
}

class Perpustakaan
{
    List<Item> Perpus = new List<Item>();

    public void TambahItem(Item item)
    {
        Perpus.Add(item);
        Console.WriteLine($"Item {item.judul} telah ditambahkan");
    }

    public void DaftarItem()
    {
        if (Perpus.Count == 0)
        {
            Console.WriteLine("Perpus lagi kosong nih, bisalah ditambah apa kek gitu");
            return;
        }
        foreach (Item item in Perpus)
        {
            item.InfoItem();
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Perpustakaan perpus = new Perpustakaan();

        Novel novel1 = new Novel();
        novel1.judul = "Lord Of The Mysteries";
        novel1.penulis = "Yuan Ye";
        novel1.tahun = 2018;

        Komik komik1 = new Komik();
        komik1.penulis = "Chugong";
        komik1.judul = "Solo Leveling";
        komik1.tahun = 2016;

        MajalahAnak MJA = new MajalahAnak();
        MJA.judul = "BOBO";
        MJA.edisi = 2500;
        MJA.tahun = 2013;
        
        MajalahTeknologi mjt = new MajalahTeknologi();
        mjt.judul = "CHIP";
        mjt.edisi = 5;
        mjt.tahun = 2005;
        
        Console.WriteLine();
        
        perpus.TambahItem(novel1);
        perpus.TambahItem(komik1);
        perpus.TambahItem(MJA);
        perpus.TambahItem(mjt);

        Console.WriteLine();

        perpus.DaftarItem();
        
        Console.WriteLine();

        List<Item> items = new List<Item> {novel1, komik1, MJA, mjt};
        foreach (Item item in items)
        {
            item.Deskripsi();
        }

        Console.WriteLine();

        novel1.BacaSinopsis();
        novel1.CekPenulis();

        komik1.TampilkanIlustrasi();
        komik1.CekPenulis();

        MJA.Infoedisi();
        MJA.KategoriAnak();

        mjt.Infoedisi();
        mjt.TopikTeknologi();
        Console.WriteLine();

        //Soal no 3
        novel1.Deskripsi();
        
        Console.WriteLine();
        //Soal No 5
        Item item1 = new Komik();
        item1.judul = "Boruto";
        item1.tahun = 2016;

    }


}