using System;

public class PhotoAlbum
{
    private int countPhotos;
    private int photosPerPage = 6;

    public PhotoAlbum()
    {
        countPhotos = 16;
    }

    public PhotoAlbum(int photosCount)
    {
        countPhotos = photosCount;
    }

    public int GetCountPhotos()
    {
        return countPhotos;
    }

    public int GetCountPages()
    {
        return (countPhotos + photosPerPage - 1) / photosPerPage;
    }
}

public class BigPhotoAlbum : PhotoAlbum
{
    public BigPhotoAlbum() : base(64)
    {
    }
}

public class PhotoAlbumTest
{
    static void Main()
    {
        PhotoAlbum defaultAlbum = new PhotoAlbum();
        Console.WriteLine($"Альбом по умолчанию: {defaultAlbum.GetCountPhotos()} фото, {defaultAlbum.GetCountPages()} страниц");

        
        PhotoAlbum customAlbum = new PhotoAlbum(24);
        Console.WriteLine($"Альбом с 24 фото: {customAlbum.GetCountPhotos()} фото, {customAlbum.GetCountPages()} страниц");

        
        BigPhotoAlbum bigAlbum = new BigPhotoAlbum();
        Console.WriteLine($"Большой альбом: {bigAlbum.GetCountPhotos()} фото, {bigAlbum.GetCountPages()} страниц");
    }
}