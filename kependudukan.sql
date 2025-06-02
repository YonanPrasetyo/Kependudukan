CREATE DATABASE Kependudukan;
USE Kependudukan;

CREATE TABLE users (
    id_user INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    nama_lengkap VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE
);

CREATE TABLE provinsi (
    id_provinsi INT PRIMARY KEY AUTO_INCREMENT,
    kode_provinsi VARCHAR(2) NOT NULL UNIQUE,
    nama_provinsi VARCHAR(100) NOT NULL
);

CREATE TABLE kabupaten_kota (
    id_kabkot INT PRIMARY KEY AUTO_INCREMENT,
    id_provinsi INT NOT NULL,
    kode_kabkot VARCHAR(4) NOT NULL UNIQUE,
    nama_kabkot VARCHAR(100) NOT NULL,
    jenis ENUM('Kabupaten', 'Kota') NOT NULL,
    FOREIGN KEY (id_provinsi) REFERENCES provinsi(id_provinsi)
);

CREATE TABLE kecamatan (
    id_kecamatan INT PRIMARY KEY AUTO_INCREMENT,
    id_kabkot INT NOT NULL,
    kode_kecamatan VARCHAR(6) NOT NULL UNIQUE,
    nama_kecamatan VARCHAR(100) NOT NULL,
    FOREIGN KEY (id_kabkot) REFERENCES kabupaten_kota(id_kabkot)
);

CREATE TABLE kelurahan_desa (
    id_keldes INT PRIMARY KEY AUTO_INCREMENT,
    id_kecamatan INT NOT NULL,
    kode_keldes VARCHAR(10) NOT NULL UNIQUE,
    nama_keldes VARCHAR(100) NOT NULL,
    jenis ENUM('Kelurahan', 'Desa') NOT NULL,
    FOREIGN KEY (id_kecamatan) REFERENCES kecamatan(id_kecamatan)
);

CREATE TABLE ekonomi (
    id_ekonomi INT PRIMARY KEY AUTO_INCREMENT,
    status ENUM('Sangat Miskin', 'Miskin', 'Menengah', 'Kaya') NOT NULL,
    status_rumah VARCHAR(50) NOT NULL
);

CREATE TABLE penduduk (
    id_penduduk INT PRIMARY KEY AUTO_INCREMENT,
    nik VARCHAR(16) NOT NULL UNIQUE,
    nama_lengkap VARCHAR(100) NOT NULL,
    jenis_kelamin ENUM('L', 'P') NOT NULL,
    tempat_lahir VARCHAR(50) NOT NULL,
    tanggal_lahir DATE NOT NULL,
    agama ENUM('Islam', 'Kristen', 'Katolik', 'Hindu', 'Buddha', 'Khonghucu', 'Lainnya') NOT NULL,
    pendidikan ENUM('Tidak Sekolah', 'SD', 'SMP', 'SMA/SMK', 'D1', 'D2', 'D3', 'S1', 'S2', 'S3') DEFAULT 'Tidak Sekolah',
    pekerjaan VARCHAR(100),
    kewarganegaraan ENUM('WNI', 'WNA') DEFAULT 'WNI',
    alamat TEXT NOT NULL,
    rt VARCHAR(3),
    rw VARCHAR(3),
    id_keldes INT NOT NULL,
    FOREIGN KEY (id_keldes) REFERENCES kelurahan_desa(id_keldes)
);

CREATE TABLE keluarga (
    id_keluarga INT PRIMARY KEY AUTO_INCREMENT,
    no_kk VARCHAR(16) NOT NULL UNIQUE,
    kepala_keluarga_id INT NOT NULL,
    alamat TEXT NOT NULL,
    rt VARCHAR(3),
    rw VARCHAR(3),
    id_keldes INT NOT NULL,
    kode_pos VARCHAR(5),
    id_ekonomi INT,
    FOREIGN KEY (kepala_keluarga_id) REFERENCES penduduk(id_penduduk),
    FOREIGN KEY (id_keldes) REFERENCES kelurahan_desa(id_keldes),
    FOREIGN KEY (id_ekonomi) REFERENCES ekonomi(id_ekonomi)
);

CREATE TABLE anggota_keluarga (
    id_anggota INT PRIMARY KEY AUTO_INCREMENT,
    id_keluarga INT NOT NULL,
    id_penduduk INT NOT NULL,
    hubungan_keluarga ENUM('Kepala Keluarga', 'Istri', 'Anak', 'Menantu', 'Cucu', 'Orangtua', 'Mertua', 'Famili Lain', 'Pembantu', 'Lainnya') NOT NULL,
    FOREIGN KEY (id_keluarga) REFERENCES keluarga(id_keluarga),
    FOREIGN KEY (id_penduduk) REFERENCES penduduk(id_penduduk),
    UNIQUE KEY unique_keluarga_penduduk (id_keluarga, id_penduduk)
);