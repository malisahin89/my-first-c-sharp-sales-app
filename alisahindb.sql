-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2.1
-- http://www.phpmyadmin.net
--
-- Anamakine: localhost
-- Üretim Zamanı: 06 Mar 2020, 00:26:25
-- Sunucu sürümü: 5.7.25-0ubuntu0.16.04.2
-- PHP Sürümü: 7.0.32-0ubuntu0.16.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `alisahindb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bolum`
--

CREATE TABLE `bolum` (
  `bolumId` int(11) NOT NULL,
  `bolumAd` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `bolumTel` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `bolum`
--

INSERT INTO `bolum` (`bolumId`, `bolumAd`, `bolumTel`) VALUES
(15, 'Front-End', '789'),
(16, 'Back-End', '987'),
(17, 'Elektrik', '654'),
(18, 'Tasarim', '456');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri`
--

CREATE TABLE `musteri` (
  `musteriId` int(11) NOT NULL,
  `musteriAd` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `musteriTel` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `musteriAdres` varchar(60) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `musteri`
--

INSERT INTO `musteri` (`musteriId`, `musteriAd`, `musteriTel`, `musteriAdres`) VALUES
(3, 'Salman Azer', '9874123', 'Merzifon'),
(4, 'Necat Basak', '7896321', 'Sivas'),
(5, 'Ali Kesik', '852147', 'Giresun'),
(6, 'Selim Sagdiç', '74123658', 'Rize');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel`
--

CREATE TABLE `personel` (
  `personelId` int(11) NOT NULL,
  `personelAd` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelTel` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelAdres` varchar(150) COLLATE utf8_turkish_ci DEFAULT NULL,
  `bolumNo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `personel`
--

INSERT INTO `personel` (`personelId`, `personelAd`, `personelTel`, `personelAdres`, `bolumNo`) VALUES
(11, 'Ahmet Selim', '778899', 'Bursa', 15),
(12, 'Recep Yurt', '998877', 'Izmir', 16),
(13, 'Muhammet Kul', '852654', 'Ordu', 17),
(14, 'Ceylan Pinar', '951753', 'Adana', 18);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `satis`
--

CREATE TABLE `satis` (
  `satisId` int(11) NOT NULL,
  `personelId` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `musteriId` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `tarih` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `urunId` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `satisAdet` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `tutar` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `satis`
--

INSERT INTO `satis` (`satisId`, `personelId`, `musteriId`, `tarih`, `urunId`, `satisAdet`, `tutar`) VALUES
(1, '11', '3', '9.6.2019', '6', '1', 2360),
(2, '12', '4', '9.6.2019', '10', '1', 10030),
(3, '14', '6', '9.6.2019', '6', '1', 2360),
(4, '13', '6', '9.6.2019', '6', '1', 2360),
(5, '13', '5', '9.6.2019', '6', '1', 640),
(6, '14', '5', '9.6.2019', '6', '5', 12000),
(7, '14', '5', '9.6.2019', '9', '5', 48000),
(8, '14', '5', '9.6.2019', '10', '5', 51000),
(9, '14', '5', '9.6.2019', '10', '5', 51000),
(10, '13', '3', '9.6.2019', '9', '5', 48000),
(11, '13', '3', '9.6.2019', '8', '5', 18120),
(12, '12', '3', '9.6.2019', '10', '4', 40800),
(13, '13', '5', '9.6.2019', '6', '5', 11800),
(14, '13', '5', '9.6.2019', '8', '5', 17818),
(15, '13', '5', '9.6.2019', '9', '2', 18880),
(16, '11', '3', '9.6.2019', '10', '2', 20060),
(17, '11', '3', '9.6.2019', '9', '1', 9440),
(18, '11', '3', '9.6.2019', '6', '1', 2360),
(19, '11', '5', '9.6.2019', '6', '8', 18880),
(20, '11', '5', '9.6.2019', '6', '9', 21240),
(21, '12', '6', '9.6.2019', '7', '8', 31904),
(22, '12', '6', '9.6.2019', '7', '9', 35892),
(23, '12', '6', '9.6.2019', '8', '9', 54360),
(24, '12', '6', '9.6.2019', '9', '9', 144000),
(25, '12', '5', '9.6.2019', '7', '8', 31904),
(26, '12', '5', '9.6.2019', '9', '8', 128000),
(27, '12', '5', '9.6.2019', '10', '8', 136000);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urun`
--

CREATE TABLE `urun` (
  `urunId` int(11) NOT NULL,
  `urunAd` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `urunFiyat` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `urun`
--

INSERT INTO `urun` (`urunId`, `urunAd`, `urunFiyat`) VALUES
(6, 'Blog Script', 2000),
(7, 'Sosyal Medya Yönetim', 1994),
(8, 'Emlak Satis Script', 3020),
(9, 'Fabrika Otomasyon', 8000),
(10, 'Yüz Tanima Giris Sistem', 8500);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `bolum`
--
ALTER TABLE `bolum`
  ADD PRIMARY KEY (`bolumId`);

--
-- Tablo için indeksler `musteri`
--
ALTER TABLE `musteri`
  ADD PRIMARY KEY (`musteriId`);

--
-- Tablo için indeksler `personel`
--
ALTER TABLE `personel`
  ADD PRIMARY KEY (`personelId`);

--
-- Tablo için indeksler `satis`
--
ALTER TABLE `satis`
  ADD PRIMARY KEY (`satisId`);

--
-- Tablo için indeksler `urun`
--
ALTER TABLE `urun`
  ADD PRIMARY KEY (`urunId`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `bolum`
--
ALTER TABLE `bolum`
  MODIFY `bolumId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- Tablo için AUTO_INCREMENT değeri `musteri`
--
ALTER TABLE `musteri`
  MODIFY `musteriId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- Tablo için AUTO_INCREMENT değeri `personel`
--
ALTER TABLE `personel`
  MODIFY `personelId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- Tablo için AUTO_INCREMENT değeri `satis`
--
ALTER TABLE `satis`
  MODIFY `satisId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
--
-- Tablo için AUTO_INCREMENT değeri `urun`
--
ALTER TABLE `urun`
  MODIFY `urunId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
