CREATE TABLE pelanggan (
	kode VARCHAR PRIMARY KEY NOT NULL,
	nama VARCHAR NOT NULL,
	alamat VARCHAR NOT NULL
);

CREATE TABLE barang (
	kode VARCHAR PRIMARY KEY NOT NULL,
	nama VARCHAR NOT NULL,
	harga DECIMAL NOT NULL
);

CREATE TABLE transaksi (
	kode VARCHAR PRIMARY KEY NOT NULL,
	tanggal DATE NOT NULL,
	kode_pelanggan VARCHAR NOT NULL,
	kode_barang VARCHAR NOT NULL,
	jumlah_barang DECIMAL NOT NULL,
	FOREIGN KEY(kode_pelanggan) REFERENCES pelanggan(kode),
	FOREIGN KEY(kode_barang) REFERENCES barang(kode)
);

INSERT INTO pelanggan (kode, nama, harga) VALUES ('B1','Yogi', 'JAKARTA');
INSERT INTO pelanggan (kode, nama, harga) VALUES ('B2','Anggi', 'BANDUNG');
INSERT INTO pelanggan (kode, nama, harga) VALUES ('B3','Rahma', 'BANDUNG');


INSERT INTO pelanggan (kode, nama, alamat) VALUES ('P1','Yogi', 'JAKARTA');
INSERT INTO pelanggan (kode, nama, alamat) VALUES ('P2','Anggi', 'BANDUNG');
INSERT INTO pelanggan (kode, nama, alamat) VALUES ('P3','Rahma', 'BANDUNG');

INSERT INTO transaksi (kode, tanggal, kode_pelanggan, kode_barang, jumlah_barang) VALUES ('TRX001', '2019-10-01', 'P1', 'B1', 3);
INSERT INTO transaksi (kode, tanggal, kode_pelanggan, kode_barang, jumlah_barang) VALUES ('TRX002', '2019-10-02', 'P2', 'B2', 2);
INSERT INTO transaksi (kode, tanggal, kode_pelanggan, kode_barang, jumlah_barang) VALUES ('TRX003', '2019-10-08', 'P2', 'B1', 5);
INSERT INTO transaksi (kode, tanggal, kode_pelanggan, kode_barang, jumlah_barang) VALUES ('TRX004', '2019-10-10', 'P1', 'B1', 1);
INSERT INTO transaksi (kode, tanggal, kode_pelanggan, kode_barang, jumlah_barang) VALUES ('TRX005', '2019-10-17', 'P3', 'B2', 2);
INSERT INTO transaksi (kode, tanggal, kode_pelanggan, kode_barang, jumlah_barang) VALUES ('TRX006', '2019-10-17', 'P2', 'B3', 1);
INSERT INTO transaksi (kode, tanggal, kode_pelanggan, kode_barang, jumlah_barang) VALUES ('TRX007', '2019-10-18', 'P3', 'B1', 4);

SELECT * FROM barang WHERE harga > 10000 ORDER BY harga ASC;

SELECT * FROM pelanggan WHERE alamat = 'BANDUNG' AND nama ILIKE '%g%';

SELECT t.kode, t.tanggal, p.nama as nama_pelanggan, b.nama as nama_barang, t.jumlah_barang as jumlah, b.harga as harga_satuan, SUM(b.harga*t.jumlah_barang) as total FROM transaksi as t JOIN pelanggan as p ON t.kode_pelanggan = p.kode JOIN barang as b ON t.kode_barang = b.kode GROUP BY t.kode, t.tanggal, p.nama, b.nama, t.jumlah_barang, b.harga ORDER BY p.nama ASC;

SELECT p.nama as nama_pelanggan, SUM(t.jumlah_barang) as jumlah, SUM(b.harga*t.jumlah_barang) as total_harga FROM transaksi as t JOIN pelanggan as p ON t.kode_pelanggan = p.kode JOIN barang as b ON t.kode_barang = b.kode GROUP BY p.nama ORDER BY p.nama ASC;