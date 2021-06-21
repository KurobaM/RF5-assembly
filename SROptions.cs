using System;
using System.ComponentModel;
using Il2CppDummyDll;
using SRDebugger;

// Token: 0x02000B35 RID: 2869
[Token(Token = "0x200077F")]
public class SROptions : INotifyPropertyChanged
{
	// Token: 0x170009D1 RID: 2513
	// (get) Token: 0x06004A10 RID: 18960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007D3")]
	public static SROptions Current
	{
		[Token(Token = "0x6003E02")]
		[Address(RVA = "0x1EF5850", Offset = "0x1EF5951", VA = "0x1EF5850")]
		get
		{
			return null;
		}
	}

	// Token: 0x06004A11 RID: 18961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E03")]
	[Address(RVA = "0x1EF58C0", Offset = "0x1EF59C1", VA = "0x1EF58C0")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x1A8B50", Offset = "0x1A8C51")]
	public static void OnStartup()
	{
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06004A12 RID: 18962 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06004A13 RID: 18963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000002")]
	public event SROptionsPropertyChanged PropertyChanged
	{
		[Token(Token = "0x6003E04")]
		[Address(RVA = "0x1EF59E0", Offset = "0x1EF5AE1", VA = "0x1EF59E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8B70", Offset = "0x1A8C71")]
		add
		{
		}
		[Token(Token = "0x6003E05")]
		[Address(RVA = "0x1EF5A90", Offset = "0x1EF5B91", VA = "0x1EF5A90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8B80", Offset = "0x1A8C81")]
		remove
		{
		}
	}

	// Token: 0x06004A14 RID: 18964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E06")]
	[Address(RVA = "0x1EF5B40", Offset = "0x1EF5C41", VA = "0x1EF5B40")]
	public void OnPropertyChanged(string propertyName)
	{
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06004A15 RID: 18965 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06004A16 RID: 18966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000003")]
	private event PropertyChangedEventHandler InterfacePropertyChangedEventHandler
	{
		[Token(Token = "0x6003E07")]
		[Address(RVA = "0x1EF6010", Offset = "0x1EF6111", VA = "0x1EF6010")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8B90", Offset = "0x1A8C91")]
		add
		{
		}
		[Token(Token = "0x6003E08")]
		[Address(RVA = "0x1EF60C0", Offset = "0x1EF61C1", VA = "0x1EF60C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8BA0", Offset = "0x1A8CA1")]
		remove
		{
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x06004A17 RID: 18967 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06004A18 RID: 18968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000004")]
	private event PropertyChangedEventHandler PropertyChanged
	{
		[Token(Token = "0x6003E09")]
		[Address(RVA = "0x1EF6170", Offset = "0x1EF6271", VA = "0x1EF6170", Slot = "4")]
		add
		{
		}
		[Token(Token = "0x6003E0A")]
		[Address(RVA = "0x1EF6220", Offset = "0x1EF6321", VA = "0x1EF6220", Slot = "5")]
		remove
		{
		}
	}

	// Token: 0x06004A19 RID: 18969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E0B")]
	[Address(RVA = "0x1EF62D0", Offset = "0x1EF63D1", VA = "0x1EF62D0")]
	public SROptions()
	{
	}

	// Token: 0x0400AA3C RID: 43580
	[Token(Token = "0x4008062")]
	[FieldOffset(Offset = "0x0")]
	private static readonly SROptions _current;

	// Token: 0x02000B36 RID: 2870
	[Token(Token = "0x2001338")]
	[Attribute(Name = "AttributeUsageAttribute", RVA = "0x1593C0", Offset = "0x1594C1")]
	public sealed class DisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
	{
		// Token: 0x06004A1B RID: 18971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F2")]
		[Address(RVA = "0x1EF6350", Offset = "0x1EF6451", VA = "0x1EF6350")]
		public DisplayNameAttribute(string displayName)
		{
		}
	}

	// Token: 0x02000B37 RID: 2871
	[Token(Token = "0x2001339")]
	[Attribute(Name = "AttributeUsageAttribute", RVA = "0x1593E0", Offset = "0x1594E1")]
	public sealed class IncrementAttribute : SRDebugger.IncrementAttribute
	{
		// Token: 0x06004A1C RID: 18972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F3")]
		[Address(RVA = "0x1EF63D0", Offset = "0x1EF64D1", VA = "0x1EF63D0")]
		public IncrementAttribute(double increment)
		{
		}
	}

	// Token: 0x02000B38 RID: 2872
	[Token(Token = "0x200133A")]
	[Attribute(Name = "AttributeUsageAttribute", RVA = "0x159400", Offset = "0x159501")]
	public sealed class NumberRangeAttribute : SRDebugger.NumberRangeAttribute
	{
		// Token: 0x06004A1D RID: 18973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F4")]
		[Address(RVA = "0x1EF63E0", Offset = "0x1EF64E1", VA = "0x1EF63E0")]
		public NumberRangeAttribute(double min, double max)
		{
		}
	}

	// Token: 0x02000B39 RID: 2873
	[Token(Token = "0x200133B")]
	[Attribute(Name = "AttributeUsageAttribute", RVA = "0x159420", Offset = "0x159521")]
	public sealed class SortAttribute : SRDebugger.SortAttribute
	{
		// Token: 0x06004A1E RID: 18974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F5")]
		[Address(RVA = "0x1EF63F0", Offset = "0x1EF64F1", VA = "0x1EF63F0")]
		public SortAttribute(int priority)
		{
		}
	}
}
