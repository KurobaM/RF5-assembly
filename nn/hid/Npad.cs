using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001554 RID: 5460
	[Token(Token = "0x2000F01")]
	public static class Npad
	{
		// Token: 0x06007BC7 RID: 31687
		[Token(Token = "0x60067A3")]
		[Address(RVA = "0x285D750", Offset = "0x285D851", VA = "0x285D750")]
		[PreserveSig]
		public static extern void Initialize();

		// Token: 0x06007BC8 RID: 31688
		[Token(Token = "0x60067A4")]
		[Address(RVA = "0x285D760", Offset = "0x285D861", VA = "0x285D760")]
		[PreserveSig]
		public static extern void SetSupportedStyleSet(NpadStyle npadStyle);

		// Token: 0x06007BC9 RID: 31689
		[Token(Token = "0x60067A5")]
		[Address(RVA = "0x285D770", Offset = "0x285D871", VA = "0x285D770")]
		[PreserveSig]
		public static extern NpadStyle GetSupportedStyleSet();

		// Token: 0x06007BCA RID: 31690
		[Token(Token = "0x60067A6")]
		[Address(RVA = "0x285D780", Offset = "0x285D881", VA = "0x285D780")]
		[PreserveSig]
		public static extern void SetSupportedIdType(NpadId[] npadIds, long count);

		// Token: 0x06007BCB RID: 31691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067A7")]
		[Address(RVA = "0x285D790", Offset = "0x285D891", VA = "0x285D790")]
		public static void SetSupportedIdType(NpadId[] npadIds)
		{
		}

		// Token: 0x06007BCC RID: 31692
		[Token(Token = "0x60067A8")]
		[Address(RVA = "0x285D7B0", Offset = "0x285D8B1", VA = "0x285D7B0")]
		[PreserveSig]
		public static extern void BindStyleSetUpdateEvent(NpadId npadId);

		// Token: 0x06007BCD RID: 31693
		[Token(Token = "0x60067A9")]
		[Address(RVA = "0x285D7C0", Offset = "0x285D8C1", VA = "0x285D7C0")]
		[PreserveSig]
		public static extern bool IsStyleSetUpdated(NpadId npadId);

		// Token: 0x06007BCE RID: 31694
		[Token(Token = "0x60067AA")]
		[Address(RVA = "0x285D7E0", Offset = "0x285D8E1", VA = "0x285D7E0")]
		[PreserveSig]
		public static extern void DestroyStyleSetUpdateEvent(NpadId npadId);

		// Token: 0x06007BCF RID: 31695
		[Token(Token = "0x60067AB")]
		[Address(RVA = "0x285D7F0", Offset = "0x285D8F1", VA = "0x285D7F0")]
		[PreserveSig]
		public static extern NpadStyle GetStyleSet(NpadId npadId);

		// Token: 0x06007BD0 RID: 31696
		[Token(Token = "0x60067AC")]
		[Address(RVA = "0x285D800", Offset = "0x285D901", VA = "0x285D800")]
		[PreserveSig]
		public static extern void Disconnect(NpadId npadId);

		// Token: 0x06007BD1 RID: 31697
		[Token(Token = "0x60067AD")]
		[Address(RVA = "0x285D810", Offset = "0x285D911", VA = "0x285D810")]
		[PreserveSig]
		public static extern byte GetPlayerLedPattern(NpadId npadId);

		// Token: 0x06007BD2 RID: 31698
		[Token(Token = "0x60067AE")]
		[Address(RVA = "0x285D820", Offset = "0x285D921", VA = "0x285D820")]
		[PreserveSig]
		public static extern Result GetControllerColor(ref NpadControllerColor pOutValue, NpadId npadId);

		// Token: 0x06007BD3 RID: 31699
		[Token(Token = "0x60067AF")]
		[Address(RVA = "0x285D840", Offset = "0x285D941", VA = "0x285D840")]
		[PreserveSig]
		public static extern Result GetControllerColor(ref NpadControllerColor pOutLeftColor, ref NpadControllerColor pOutRightColor, NpadId npadId);

		// Token: 0x06007BD4 RID: 31700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B0")]
		[Address(RVA = "0x285D860", Offset = "0x285D961", VA = "0x285D860")]
		public static void GetState(ref NpadState pOutValue, NpadId npadId, NpadStyle npadStyle)
		{
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x0002BCE0 File Offset: 0x00029EE0
		[Token(Token = "0x60067B1")]
		[Address(RVA = "0x285D950", Offset = "0x285DA51", VA = "0x285D950")]
		public static int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle)
		{
			return 0;
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06007BD6 RID: 31702 RVA: 0x0002BCF8 File Offset: 0x00029EF8
		[Token(Token = "0x17000B51")]
		public static ErrorRange ResultColorNotAvailable
		{
			[Token(Token = "0x60067B2")]
			[Address(RVA = "0x285E050", Offset = "0x285E151", VA = "0x285E050")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06007BD7 RID: 31703 RVA: 0x0002BD10 File Offset: 0x00029F10
		[Token(Token = "0x17000B52")]
		public static ErrorRange ResultControllerNotConnected
		{
			[Token(Token = "0x60067B3")]
			[Address(RVA = "0x285E060", Offset = "0x285E161", VA = "0x285E060")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x0401BF3A RID: 114490
		[Token(Token = "0x401886C")]
		public const int StateCountMax = 16;
	}
}
