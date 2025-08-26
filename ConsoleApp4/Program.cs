using System;

public class PhotoAlbum
{
    private int _countPhotos;
    private int _photosPerPage = 6;

    public PhotoAlbum()
    {
        _countPhotos = 16;
    }

    public PhotoAlbum(int photosCount)
    {
        _countPhotos = photosCount;
    }

    public int GetCountPhotos()
    {
        return _countPhotos;
    }

    public int GetCountPages()
    {
        return (_countPhotos + _photosPerPage - 1) / _photosPerPage;
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