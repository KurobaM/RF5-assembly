using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5Input
{
	// Token: 0x02001039 RID: 4153
	[Token(Token = "0x2000A89")]
	[Attribute(Name = "DefaultExecutionOrder", RVA = "0x149F90", Offset = "0x14A091")]
	public abstract class Pad : MonoBehaviour
	{
		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06006849 RID: 26697 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600684A RID: 26698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A72")]
		public static Dictionary<AKey, Key> Keys
		{
			[Token(Token = "0x60056CD")]
			[Address(RVA = "0x21700F0", Offset = "0x21701F1", VA = "0x21700F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD140", Offset = "0x1AD241")]
			get
			{
				return null;
			}
			[Token(Token = "0x60056CE")]
			[Address(RVA = "0x2170160", Offset = "0x2170261", VA = "0x2170160")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD150", Offset = "0x1AD251")]
			protected set
			{
			}
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x00023A18 File Offset: 0x00021C18
		[Token(Token = "0x60056CF")]
		[Address(RVA = "0x21701D0", Offset = "0x21702D1", VA = "0x21701D0")]
		public static bool Push(AKey key)
		{
			return default(bool);
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x00023A30 File Offset: 0x00021C30
		[Token(Token = "0x60056D0")]
		[Address(RVA = "0x2170400", Offset = "0x2170501", VA = "0x2170400")]
		public static bool Edge(AKey key)
		{
			return default(bool);
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x00023A48 File Offset: 0x00021C48
		[Token(Token = "0x60056D1")]
		[Address(RVA = "0x2170630", Offset = "0x2170731", VA = "0x2170630")]
		public static bool End(AKey key)
		{
			return default(bool);
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x00023A60 File Offset: 0x00021C60
		[Token(Token = "0x60056D2")]
		[Address(RVA = "0x2170860", Offset = "0x2170961", VA = "0x2170860")]
		public static bool Repeat(AKey key)
		{
			return default(bool);
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x0600684F RID: 26703 RVA: 0x00023A78 File Offset: 0x00021C78
		// (set) Token: 0x06006850 RID: 26704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A73")]
		public static bool Enable
		{
			[Token(Token = "0x60056D3")]
			[Address(RVA = "0x2170A90", Offset = "0x2170B91", VA = "0x2170A90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD160", Offset = "0x1AD261")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056D4")]
			[Address(RVA = "0x2170B00", Offset = "0x2170C01", VA = "0x2170B00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD170", Offset = "0x1AD271")]
			set
			{
			}
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D5")]
		[Address(RVA = "0x2170B70", Offset = "0x2170C71", VA = "0x2170B70")]
		public static void SetKey(Key key)
		{
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x00023A90 File Offset: 0x00021C90
		[Token(Token = "0x60056D6")]
		[Address(RVA = "0x21702D0", Offset = "0x21703D1", VA = "0x21702D0")]
		public static bool Push(Key key)
		{
			return default(bool);
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x00023AA8 File Offset: 0x00021CA8
		[Token(Token = "0x60056D7")]
		[Address(RVA = "0x2170500", Offset = "0x2170601", VA = "0x2170500")]
		public static bool Edge(Key key)
		{
			return default(bool);
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x00023AC0 File Offset: 0x00021CC0
		[Token(Token = "0x60056D8")]
		[Address(RVA = "0x2170730", Offset = "0x2170831", VA = "0x2170730")]
		public static bool End(Key key)
		{
			return default(bool);
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x00023AD8 File Offset: 0x00021CD8
		[Token(Token = "0x60056D9")]
		[Address(RVA = "0x2170960", Offset = "0x2170A61", VA = "0x2170960")]
		public static bool Repeat(Key key)
		{
			return default(bool);
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x00023AF0 File Offset: 0x00021CF0
		[Token(Token = "0x60056DA")]
		[Address(RVA = "0x2170CB0", Offset = "0x2170DB1", VA = "0x2170CB0")]
		public static float AnalogLX()
		{
			return 0f;
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x00023B08 File Offset: 0x00021D08
		[Token(Token = "0x60056DB")]
		[Address(RVA = "0x2170DD0", Offset = "0x2170ED1", VA = "0x2170DD0")]
		public static float AnalogLY()
		{
			return 0f;
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x00023B20 File Offset: 0x00021D20
		[Token(Token = "0x60056DC")]
		[Address(RVA = "0x2170EF0", Offset = "0x2170FF1", VA = "0x2170EF0")]
		public static float AnalogRX()
		{
			return 0f;
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x00023B38 File Offset: 0x00021D38
		[Token(Token = "0x60056DD")]
		[Address(RVA = "0x2171010", Offset = "0x2171111", VA = "0x2171010")]
		public static float AnalogRY()
		{
			return 0f;
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x00023B50 File Offset: 0x00021D50
		[Token(Token = "0x60056DE")]
		[Address(RVA = "0x2171130", Offset = "0x2171231", VA = "0x2171130")]
		public static bool IsLeverGatya()
		{
			return default(bool);
		}

		// Token: 0x0600685B RID: 26715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DF")]
		[Address(RVA = "0x2171200", Offset = "0x2171301", VA = "0x2171200")]
		public static void Create()
		{
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E0")]
		[Address(RVA = "0x2171350", Offset = "0x2171451", VA = "0x2171350")]
		public static void Initialize()
		{
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x0600685D RID: 26717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600685E RID: 26718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A74")]
		private static Pad Instance
		{
			[Token(Token = "0x60056E1")]
			[Address(RVA = "0x2171440", Offset = "0x2171541", VA = "0x2171440")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD180", Offset = "0x1AD281")]
			get
			{
				return null;
			}
			[Token(Token = "0x60056E2")]
			[Address(RVA = "0x21714B0", Offset = "0x21715B1", VA = "0x21714B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD190", Offset = "0x1AD291")]
			set
			{
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x0600685F RID: 26719 RVA: 0x00023B68 File Offset: 0x00021D68
		// (set) Token: 0x06006860 RID: 26720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A75")]
		public static Key Override
		{
			[Token(Token = "0x60056E3")]
			[Address(RVA = "0x2171520", Offset = "0x2171621", VA = "0x2171520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD1A0", Offset = "0x1AD2A1")]
			get
			{
				return (Key)0;
			}
			[Token(Token = "0x60056E4")]
			[Address(RVA = "0x2171590", Offset = "0x2171691", VA = "0x2171590")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD1B0", Offset = "0x1AD2B1")]
			protected set
			{
			}
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E5")]
		[Address(RVA = "0x2171600", Offset = "0x2171701", VA = "0x2171600", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E6")]
		[Address(RVA = "0x2171700", Offset = "0x2171801", VA = "0x2171700")]
		private void Update()
		{
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E7")]
		[Address(RVA = "0x2172010", Offset = "0x2172111", VA = "0x2172010")]
		public static void SetTutorialBlock(bool block)
		{
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E8")]
		[Address(RVA = "0x2172100", Offset = "0x2172201", VA = "0x2172100")]
		public static void SetTutorialBlock(Key key, bool block)
		{
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E9")]
		[Address(RVA = "0x21721B0", Offset = "0x21722B1", VA = "0x21721B0")]
		public static void TutorialEnableKey(int key)
		{
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056EA")]
		[Address(RVA = "0x2172260", Offset = "0x2172361", VA = "0x2172260")]
		private static PadData PadDataTutorial(PadData padData)
		{
			return null;
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06006867 RID: 26727 RVA: 0x00023B80 File Offset: 0x00021D80
		// (set) Token: 0x06006868 RID: 26728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A76")]
		public static float VibPowerLow
		{
			[Token(Token = "0x60056EB")]
			[Address(RVA = "0x2172330", Offset = "0x2172431", VA = "0x2172330")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD1C0", Offset = "0x1AD2C1")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60056EC")]
			[Address(RVA = "0x21723A0", Offset = "0x21724A1", VA = "0x21723A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD1D0", Offset = "0x1AD2D1")]
			protected set
			{
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06006869 RID: 26729 RVA: 0x00023B98 File Offset: 0x00021D98
		// (set) Token: 0x0600686A RID: 26730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A77")]
		public static float VibPowerHigh
		{
			[Token(Token = "0x60056ED")]
			[Address(RVA = "0x2172420", Offset = "0x2172521", VA = "0x2172420")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD1E0", Offset = "0x1AD2E1")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60056EE")]
			[Address(RVA = "0x2172490", Offset = "0x2172591", VA = "0x2172490")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD1F0", Offset = "0x1AD2F1")]
			protected set
			{
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x00023BB0 File Offset: 0x00021DB0
		// (set) Token: 0x0600686C RID: 26732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A78")]
		public static float VibTime
		{
			[Token(Token = "0x60056EF")]
			[Address(RVA = "0x2172510", Offset = "0x2172611", VA = "0x2172510")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD200", Offset = "0x1AD301")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60056F0")]
			[Address(RVA = "0x2172580", Offset = "0x2172681", VA = "0x2172580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD210", Offset = "0x1AD311")]
			protected set
			{
			}
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F1")]
		[Address(RVA = "0x2172600", Offset = "0x2172701", VA = "0x2172600")]
		public static void PlayVibration(Pad.VibrationType type)
		{
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F2")]
		[Address(RVA = "0x2172820", Offset = "0x2172921", VA = "0x2172820")]
		public static void StopVibration()
		{
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x0600686F RID: 26735 RVA: 0x00023BC8 File Offset: 0x00021DC8
		// (set) Token: 0x06006870 RID: 26736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A79")]
		private static int LeverGatyaFrame
		{
			[Token(Token = "0x60056F3")]
			[Address(RVA = "0x21729A0", Offset = "0x2172AA1", VA = "0x21729A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD220", Offset = "0x1AD321")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60056F4")]
			[Address(RVA = "0x2172A10", Offset = "0x2172B11", VA = "0x2172A10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD230", Offset = "0x1AD331")]
			set
			{
			}
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F5")]
		[Address(RVA = "0x2171D80", Offset = "0x2171E81", VA = "0x2171D80")]
		private void UpdateLeverGatya()
		{
		}

		// Token: 0x06006872 RID: 26738
		[Token(Token = "0x60056F6")]
		protected abstract void SetKeyAssign();

		// Token: 0x06006873 RID: 26739
		[Token(Token = "0x60056F7")]
		protected abstract void InitializePad();

		// Token: 0x06006874 RID: 26740
		[Token(Token = "0x60056F8")]
		protected abstract void UpdatePad();

		// Token: 0x06006875 RID: 26741
		[Token(Token = "0x60056F9")]
		protected abstract void UpdateVibration();

		// Token: 0x06006876 RID: 26742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FA")]
		[Address(RVA = "0x2172A80", Offset = "0x2172B81", VA = "0x2172A80")]
		protected Pad()
		{
		}

		// Token: 0x040170C0 RID: 94400
		[Token(Token = "0x4013D43")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180310", Offset = "0x180411")]
		private static Dictionary<AKey, Key> <Keys>k__BackingField;

		// Token: 0x040170C1 RID: 94401
		[Token(Token = "0x4013D44")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180320", Offset = "0x180421")]
		private static bool <Enable>k__BackingField;

		// Token: 0x040170C2 RID: 94402
		[Token(Token = "0x4013D45")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180330", Offset = "0x180431")]
		private static Pad <Instance>k__BackingField;

		// Token: 0x040170C3 RID: 94403
		[Token(Token = "0x4013D46")]
		private const Key REPEAT = Key.A | Key.B | Key.L | Key.R | Key.ZL | Key.ZR | Key.JU | Key.JR | Key.JD | Key.JL | Key.ALU | Key.ALR | Key.ALD | Key.ALL;

		// Token: 0x040170C4 RID: 94404
		[Token(Token = "0x4013D47")]
		protected const float AXIS_ROUND_RATE = 0.25f;

		// Token: 0x040170C5 RID: 94405
		[Token(Token = "0x4013D48")]
		protected const float REPEAT_1ST_TIME = 0.2f;

		// Token: 0x040170C6 RID: 94406
		[Token(Token = "0x4013D49")]
		protected const float REPEAT_2ND_TIME = 0.1f;

		// Token: 0x040170C7 RID: 94407
		[Token(Token = "0x4013D4A")]
		[FieldOffset(Offset = "0x18")]
		protected static PadData Data;

		// Token: 0x040170C8 RID: 94408
		[Token(Token = "0x4013D4B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180340", Offset = "0x180441")]
		private static Key <Override>k__BackingField;

		// Token: 0x040170C9 RID: 94409
		[Token(Token = "0x4013D4C")]
		[FieldOffset(Offset = "0x28")]
		public static Func<PadData, PadData> PadDataTakeover;

		// Token: 0x040170CA RID: 94410
		[Token(Token = "0x4013D4D")]
		[FieldOffset(Offset = "0x30")]
		protected static float repeat_count_;

		// Token: 0x040170CB RID: 94411
		[Token(Token = "0x4013D4E")]
		[FieldOffset(Offset = "0x34")]
		protected static float repeat_wait_;

		// Token: 0x040170CC RID: 94412
		[Token(Token = "0x4013D4F")]
		[FieldOffset(Offset = "0x38")]
		private static Key TutorialBlock;

		// Token: 0x040170CD RID: 94413
		[Token(Token = "0x4013D50")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Vector3[] VibrationTbl;

		// Token: 0x040170CE RID: 94414
		[Token(Token = "0x4013D51")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180350", Offset = "0x180451")]
		private static float <VibPowerLow>k__BackingField;

		// Token: 0x040170CF RID: 94415
		[Token(Token = "0x4013D52")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180360", Offset = "0x180461")]
		private static float <VibPowerHigh>k__BackingField;

		// Token: 0x040170D0 RID: 94416
		[Token(Token = "0x4013D53")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180370", Offset = "0x180471")]
		private static float <VibTime>k__BackingField;

		// Token: 0x040170D1 RID: 94417
		[Token(Token = "0x4013D54")]
		private const float LEVER_GATYA_RANGE = 0.8f;

		// Token: 0x040170D2 RID: 94418
		[Token(Token = "0x4013D55")]
		private const int LEVER_GATYA_WAIT_FRAME = 3;

		// Token: 0x040170D3 RID: 94419
		[Token(Token = "0x4013D56")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180380", Offset = "0x180481")]
		private static int <LeverGatyaFrame>k__BackingField;

		// Token: 0x040170D4 RID: 94420
		[Token(Token = "0x4013D57")]
		[FieldOffset(Offset = "0x18")]
		private float PrevHorizontal;

		// Token: 0x040170D5 RID: 94421
		[Token(Token = "0x4013D58")]
		[FieldOffset(Offset = "0x1C")]
		private float PrevVeritical;

		// Token: 0x0200103A RID: 4154
		[Token(Token = "0x200151C")]
		public enum VibrationType
		{
			// Token: 0x040170D7 RID: 94423
			[Token(Token = "0x401BF8A")]
			VERYSMALL,
			// Token: 0x040170D8 RID: 94424
			[Token(Token = "0x401BF8B")]
			SMALL,
			// Token: 0x040170D9 RID: 94425
			[Token(Token = "0x401BF8C")]
			MIDDLE,
			// Token: 0x040170DA RID: 94426
			[Token(Token = "0x401BF8D")]
			BIG
		}
	}
}
