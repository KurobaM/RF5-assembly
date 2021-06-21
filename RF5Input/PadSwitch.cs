using System;
using Il2CppDummyDll;
using nn;
using nn.hid;

namespace RF5Input
{
	// Token: 0x0200103E RID: 4158
	[Token(Token = "0x2000A8D")]
	[Attribute(Name = "DefaultExecutionOrder", RVA = "0x149FB0", Offset = "0x14A0B1")]
	public class PadSwitch : Pad
	{
		// Token: 0x0600687D RID: 26749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005701")]
		[Address(RVA = "0x21731C0", Offset = "0x21732C1", VA = "0x21731C0", Slot = "5")]
		protected override void SetKeyAssign()
		{
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x0600687E RID: 26750 RVA: 0x00023BE0 File Offset: 0x00021DE0
		// (set) Token: 0x0600687F RID: 26751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7A")]
		public bool PadReady
		{
			[Token(Token = "0x6005702")]
			[Address(RVA = "0x21733C0", Offset = "0x21734C1", VA = "0x21733C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD240", Offset = "0x1AD341")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005703")]
			[Address(RVA = "0x21733D0", Offset = "0x21734D1", VA = "0x21733D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD250", Offset = "0x1AD351")]
			protected set
			{
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06006880 RID: 26752 RVA: 0x00023BF8 File Offset: 0x00021DF8
		// (set) Token: 0x06006881 RID: 26753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7B")]
		public static NpadId NpadActiveId
		{
			[Token(Token = "0x6005704")]
			[Address(RVA = "0x21733E0", Offset = "0x21734E1", VA = "0x21733E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD260", Offset = "0x1AD361")]
			get
			{
				return NpadId.No1;
			}
			[Token(Token = "0x6005705")]
			[Address(RVA = "0x2173450", Offset = "0x2173551", VA = "0x2173450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD270", Offset = "0x1AD371")]
			private set
			{
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06006882 RID: 26754 RVA: 0x00023C10 File Offset: 0x00021E10
		// (set) Token: 0x06006883 RID: 26755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7C")]
		public static NpadStyle NpadActiveStyle
		{
			[Token(Token = "0x6005706")]
			[Address(RVA = "0x21734C0", Offset = "0x21735C1", VA = "0x21734C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD280", Offset = "0x1AD381")]
			get
			{
				return NpadStyle.None;
			}
			[Token(Token = "0x6005707")]
			[Address(RVA = "0x2173530", Offset = "0x2173631", VA = "0x2173530")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD290", Offset = "0x1AD391")]
			private set
			{
			}
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005708")]
		[Address(RVA = "0x21735A0", Offset = "0x21736A1", VA = "0x21735A0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005709")]
		[Address(RVA = "0x2173C40", Offset = "0x2173D41", VA = "0x2173C40", Slot = "6")]
		protected override void InitializePad()
		{
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570A")]
		[Address(RVA = "0x2173C50", Offset = "0x2173D51", VA = "0x2173C50", Slot = "7")]
		protected override void UpdatePad()
		{
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x00023C28 File Offset: 0x00021E28
		[Token(Token = "0x600570B")]
		[Address(RVA = "0x21742F0", Offset = "0x21743F1", VA = "0x21742F0")]
		public bool NpadCheck()
		{
			return default(bool);
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570C")]
		[Address(RVA = "0x2174710", Offset = "0x2174811", VA = "0x2174710")]
		private void ShowControllerSupport()
		{
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570D")]
		[Address(RVA = "0x2173A60", Offset = "0x2173B61", VA = "0x2173A60")]
		private void InitializeVibration()
		{
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570E")]
		[Address(RVA = "0x2173B00", Offset = "0x2173C01", VA = "0x2173B00")]
		private void GetVibrationDevice(NpadId id, NpadStyle style)
		{
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570F")]
		[Address(RVA = "0x2174910", Offset = "0x2174A11", VA = "0x2174910", Slot = "8")]
		protected override void UpdateVibration()
		{
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005710")]
		[Address(RVA = "0x2174C80", Offset = "0x2174D81", VA = "0x2174C80")]
		public PadSwitch()
		{
		}

		// Token: 0x040170EC RID: 94444
		[Token(Token = "0x4013D6A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1803B0", Offset = "0x1804B1")]
		private bool <PadReady>k__BackingField;

		// Token: 0x040170ED RID: 94445
		[Token(Token = "0x4013D6B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NpadId[] NpadIds;

		// Token: 0x040170EE RID: 94446
		[Token(Token = "0x4013D6C")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1803C0", Offset = "0x1804C1")]
		private static NpadId <NpadActiveId>k__BackingField;

		// Token: 0x040170EF RID: 94447
		[Token(Token = "0x4013D6D")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1803D0", Offset = "0x1804D1")]
		private static NpadStyle <NpadActiveStyle>k__BackingField;

		// Token: 0x040170F0 RID: 94448
		[Token(Token = "0x4013D6E")]
		[FieldOffset(Offset = "0x28")]
		private NpadState npadState_;

		// Token: 0x040170F1 RID: 94449
		[Token(Token = "0x4013D6F")]
		[FieldOffset(Offset = "0x58")]
		private ControllerSupportArg controllerSupportArg_;

		// Token: 0x040170F2 RID: 94450
		[Token(Token = "0x4013D70")]
		[FieldOffset(Offset = "0x88")]
		private ControllerSupportResultInfo returnArg_;

		// Token: 0x040170F3 RID: 94451
		[Token(Token = "0x4013D71")]
		[FieldOffset(Offset = "0x94")]
		private Result result_;

		// Token: 0x040170F4 RID: 94452
		[Token(Token = "0x4013D72")]
		private const int vibrationDeviceCountMax_ = 2;

		// Token: 0x040170F5 RID: 94453
		[Token(Token = "0x4013D73")]
		[FieldOffset(Offset = "0x98")]
		private int vibrationDeviceCount_;

		// Token: 0x040170F6 RID: 94454
		[Token(Token = "0x4013D74")]
		[FieldOffset(Offset = "0xA0")]
		private VibrationDeviceHandle[] vibrationDeviceHandles_;

		// Token: 0x040170F7 RID: 94455
		[Token(Token = "0x4013D75")]
		[FieldOffset(Offset = "0xA8")]
		private VibrationDeviceInfo[] vibrationDeviceInfos_;

		// Token: 0x040170F8 RID: 94456
		[Token(Token = "0x4013D76")]
		[FieldOffset(Offset = "0xB0")]
		private VibrationValue vibrationValue_;
	}
}
