using System;

namespace TestMsgPack.Data
{

  public class Primitive : Base
  {
    public Int16           Int16          { get; set; }
    public int             Int32          { get; set; }
    public Int64           Int64          { get; set; }
    public UInt16          UInt16         { get; set; }
    public uint            UInt32         { get; set; }
    public UInt64          UInt64         { get; set; }
    public float           Float          { get; set; }
    public double          Double         { get; set; }
    public bool            Bool           { get; set; }
    public byte            Byte           { get; set; }
    public sbyte           SByte          { get; set; }
    public char            Char           { get; set; }
    public TimeSpan        TimeSpan       { get; set; }
    public DateTime        DateTime       { get; set; }
    public DateTimeOffset  DateTimeOffset { get; set; }
    public string          String         { get; set; }

    public override void DataSet() {
      Int16          = Int16.MinValue;
      Int32          = Int32.MinValue;
      Int64          = Int64.MinValue;
      UInt16         = UInt16.MaxValue;
      UInt32         = UInt32.MaxValue;
      UInt64         = UInt64.MaxValue;
      Float          = Single.MinValue;
      Double         = Double.MaxValue;
      Bool           = true;
      Byte           = Byte.MinValue;
      SByte          = SByte.MaxValue;
      Char           = 'a';
      TimeSpan       = TimeSpan.FromSeconds(1);
      DateTime       = DateTime.Now;
      DateTimeOffset = new DateTimeOffset(DateTime);
      String         = "Hello!! Can you see this text?";
    }
  }

}