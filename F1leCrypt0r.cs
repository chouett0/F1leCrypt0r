using System;
using System.IO;

class ReadBinFile {
	static public void Main(string[] args) {
		byte mask = 0xFF;
		byte[] data = ReadBin(@"/Users/chouett0/test/test5.txt");

		for (int i=0;i<data.Length; i++) {
			data[i] = (byte)(data[i]^mask);

		}

		WriteBin(@"/Users/chouett0/test/test6.txt", data);
	
	}

	static byte[] ReadBin(string filename) {
		FileStream fs = new FileStream(filename,FileMode.Open);
		byte[] b = new byte[fs.Length];
		fs.Read(b, 0, b.Length);

//		Console.WriteLine(BitConverter.ToString(b));
		return b;

	}

	static void WriteBin(string filename, byte[] data) {
		using (FileStream fs2 = new FileStream(filename, FileMode.Create, FileAccess.Write)) {
			using (BinaryWriter bw = new BinaryWriter(fs2)) {
				bw.Write(data);
				
			}
		}

	}

}