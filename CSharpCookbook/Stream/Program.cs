using System.Text;

int count;
byte[] byteArray;
char[] charArray;
UnicodeEncoding uniEncoding = new UnicodeEncoding();

// Create the data to write to the stream.
byte[] firstString = uniEncoding.GetBytes(
    "Invalid file path characters are: ");
byte[] secondString = uniEncoding.GetBytes(
    Path.GetInvalidPathChars());

Console.WriteLine(Path.GetInvalidPathChars());

using (MemoryStream memStream = new MemoryStream(100))
{
    // so effectively, it's an array of bytes
    memStream.Write(firstString, 0, firstString.Length);
    // I can't really access it.
    Console.WriteLine(firstString);


    // Write the second string to the stream, byte by byte. (alternate way)
    count = 0;
    while (count < secondString.Length)
    {
        memStream.WriteByte(secondString[count++]);
    }

    // Write the stream properties to the console.
    Console.WriteLine(
        "Capacity = {0}, Length = {1}, Position = {2}\n",
        memStream.Capacity.ToString(),
        memStream.Length.ToString(),
        memStream.Position.ToString());

    // We are positioned at the end
    memStream.Seek(0, SeekOrigin.Begin);

    // Read the first 20 bytes from the stream.
    byteArray = new byte[memStream.Length];
    count = memStream.Read(byteArray, 0, 20);

    Console.WriteLine(BitConverter.ToString(byteArray));
    // Read the remaining bytes, byte by byte.
    while (count < memStream.Length)
    {
        byteArray[count++] = (byte)memStream.ReadByte();
    }

    Console.WriteLine(BitConverter.ToString(byteArray));

    charArray = new char[uniEncoding.GetCharCount(
        byteArray, 0, count)];
    uniEncoding.GetDecoder().GetChars(
        byteArray, 0, count, charArray, 0);
    Console.WriteLine(charArray);
}