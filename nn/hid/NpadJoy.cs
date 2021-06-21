using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001560 RID: 5472
	[Token(Token = "0x2000F0D")]
	public static class NpadJoy
	{
		// Token: 0x06007BE8 RID: 31720
		[Token(Token = "0x60067C4")]
		[Address(RVA = "0x285E830", Offset = "0x285E931", VA = "0x285E830")]
		[PreserveSig]
		public static extern NpadJoyAssignmentMode GetAssignment(NpadId npadId);

		// Token: 0x06007BE9 RID: 31721
		[Token(Token = "0x60067C5")]
		[Address(RVA = "0x285E840", Offset = "0x285E941", VA = "0x285E840")]
		[PreserveSig]
		public static extern void SetAssignmentModeSingle(NpadId npadId);

		// Token: 0x06007BEA RID: 31722
		[Token(Token = "0x60067C6")]
		[Address(RVA = "0x285E850", Offset = "0x285E951", VA = "0x285E850")]
		[PreserveSig]
		public static extern void SetAssignmentModeSingle(NpadId npadId, NpadJoyDeviceType deviceType);

		// Token: 0x06007BEB RID: 31723
		[Token(Token = "0x60067C7")]
		[Address(RVA = "0x285E860", Offset = "0x285E961", VA = "0x285E860")]
		[PreserveSig]
		public static extern void SetAssignmentModeSingle(ref NpadId pOutValue, NpadId npadId, NpadJoyDeviceType deviceType);

		// Token: 0x06007BEC RID: 31724
		[Token(Token = "0x60067C8")]
		[Address(RVA = "0x285E870", Offset = "0x285E971", VA = "0x285E870")]
		[PreserveSig]
		public static extern void SetAssignmentModeDual(NpadId npadId);

		// Token: 0x06007BED RID: 31725
		[Token(Token = "0x60067C9")]
		[Address(RVA = "0x285E880", Offset = "0x285E981", VA = "0x285E880")]
		[PreserveSig]
		public static extern Result MergeSingleAsDual(NpadId npadId1, NpadId npadId2);

		// Token: 0x06007BEE RID: 31726
		[Token(Token = "0x60067CA")]
		[Address(RVA = "0x285E8A0", Offset = "0x285E9A1", VA = "0x285E8A0")]
		[PreserveSig]
		public static extern void SwapAssignment(NpadId npadId1, NpadId npadId2);

		// Token: 0x06007BEF RID: 31727
		[Token(Token = "0x60067CB")]
		[Address(RVA = "0x285E8B0", Offset = "0x285E9B1", VA = "0x285E8B0")]
		[PreserveSig]
		public static extern void SetHoldType(NpadJoyHoldType holdType);

		// Token: 0x06007BF0 RID: 31728
		[Token(Token = "0x60067CC")]
		[Address(RVA = "0x285E8C0", Offset = "0x285E9C1", VA = "0x285E8C0")]
		[PreserveSig]
		public static extern NpadJoyHoldType GetHoldType();

		// Token: 0x06007BF1 RID: 31729
		[Token(Token = "0x60067CD")]
		[Address(RVA = "0x285E8D0", Offset = "0x285E9D1", VA = "0x285E8D0")]
		[PreserveSig]
		public static extern void StartLrAssignmentMode();

		// Token: 0x06007BF2 RID: 31730
		[Token(Token = "0x60067CE")]
		[Address(RVA = "0x285E8E0", Offset = "0x285E9E1", VA = "0x285E8E0")]
		[PreserveSig]
		public static extern void StopLrAssignmentMode();

		// Token: 0x06007BF3 RID: 31731
		[Token(Token = "0x60067CF")]
		[Address(RVA = "0x285E8F0", Offset = "0x285E9F1", VA = "0x285E8F0")]
		[PreserveSig]
		public static extern void SetHandheldActivationMode(NpadHandheldActivationMode activationMode);

		// Token: 0x06007BF4 RID: 31732
		[Token(Token = "0x60067D0")]
		[Address(RVA = "0x285E900", Offset = "0x285EA01", VA = "0x285E900")]
		[PreserveSig]
		public static extern NpadHandheldActivationMode GetHandheldActivationMode();

		// Token: 0x06007BF5 RID: 31733
		[Token(Token = "0x60067D1")]
		[Address(RVA = "0x285E910", Offset = "0x285EA11", VA = "0x285E910")]
		[PreserveSig]
		public static extern void SetCommunicationMode(NpadCommunicationMode mode);

		// Token: 0x06007BF6 RID: 31734
		[Token(Token = "0x60067D2")]
		[Address(RVA = "0x285E920", Offset = "0x285EA21", VA = "0x285E920")]
		[PreserveSig]
		public static extern NpadCommunicationMode GetCommunicationMode();

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06007BF7 RID: 31735 RVA: 0x0002BD70 File Offset: 0x00029F70
		[Token(Token = "0x17000B53")]
		public static ErrorRange ResultDualConnected
		{
			[Token(Token = "0x60067D3")]
			[Address(RVA = "0x285E930", Offset = "0x285EA31", VA = "0x285E930")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06007BF8 RID: 31736 RVA: 0x0002BD88 File Offset: 0x00029F88
		[Token(Token = "0x17000B54")]
		public static ErrorRange ResultSameJoyTypeConnected
		{
			[Token(Token = "0x60067D4")]
			[Address(RVA = "0x285E940", Offset = "0x285EA41", VA = "0x285E940")]
			get
			{
				return default(ErrorRange);
			}
		}
	}
}
