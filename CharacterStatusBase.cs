using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008A1 RID: 2209
[Token(Token = "0x20005B7")]
public abstract class CharacterStatusBase : StatusBase
{
	// Token: 0x1700080F RID: 2063
	// (get) Token: 0x06003A05 RID: 14853 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A06 RID: 14854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000654")]
	public StatusDataBase StatusData
	{
		[Token(Token = "0x6003073")]
		[Address(RVA = "0x1E97110", Offset = "0x1E97211", VA = "0x1E97110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6010", Offset = "0x1A6111")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003074")]
		[Address(RVA = "0x1E97120", Offset = "0x1E97221", VA = "0x1E97120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6020", Offset = "0x1A6121")]
		protected set
		{
		}
	}

	// Token: 0x06003A07 RID: 14855
	[Token(Token = "0x6003075")]
	protected abstract CharaParamDataTable GetCharaParam();

	// Token: 0x17000810 RID: 2064
	// (get) Token: 0x06003A08 RID: 14856 RVA: 0x00014118 File Offset: 0x00012318
	[Token(Token = "0x17000655")]
	protected virtual bool IsBoss
	{
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x1E97130", Offset = "0x1E97231", VA = "0x1E97130", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003A09 RID: 14857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003077")]
	[Address(RVA = "0x1E97140", Offset = "0x1E97241", VA = "0x1E97140", Slot = "10")]
	public override void Renew()
	{
	}

	// Token: 0x06003A0A RID: 14858 RVA: 0x00014130 File Offset: 0x00012330
	[Token(Token = "0x6003078")]
	[Address(RVA = "0x1E97520", Offset = "0x1E97621", VA = "0x1E97520", Slot = "12")]
	public override ValueTuple<Parameter, EquipSubAttributeCollection> CalcCurrentParameter(HumanEquip humanEquip, bool isWeapon)
	{
		return default(ValueTuple<Parameter, EquipSubAttributeCollection>);
	}

	// Token: 0x17000811 RID: 2065
	// (get) Token: 0x06003A0B RID: 14859 RVA: 0x00014148 File Offset: 0x00012348
	// (set) Token: 0x06003A0C RID: 14860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000656")]
	public int Level
	{
		[Token(Token = "0x6003079")]
		[Address(RVA = "0x1E98640", Offset = "0x1E98741", VA = "0x1E98640")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600307A")]
		[Address(RVA = "0x1E98660", Offset = "0x1E98761", VA = "0x1E98660")]
		protected set
		{
		}
	}

	// Token: 0x17000812 RID: 2066
	// (get) Token: 0x06003A0D RID: 14861 RVA: 0x00014160 File Offset: 0x00012360
	// (set) Token: 0x06003A0E RID: 14862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000657")]
	public int Exp
	{
		[Token(Token = "0x600307B")]
		[Address(RVA = "0x1E98680", Offset = "0x1E98781", VA = "0x1E98680")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600307C")]
		[Address(RVA = "0x1E986A0", Offset = "0x1E987A1", VA = "0x1E986A0")]
		set
		{
		}
	}

	// Token: 0x06003A0F RID: 14863 RVA: 0x00014178 File Offset: 0x00012378
	[Token(Token = "0x600307D")]
	[Address(RVA = "0x1E986C0", Offset = "0x1E987C1", VA = "0x1E986C0")]
	public int GetNeedExp()
	{
		return 0;
	}

	// Token: 0x17000813 RID: 2067
	// (get) Token: 0x06003A10 RID: 14864 RVA: 0x00014190 File Offset: 0x00012390
	// (set) Token: 0x06003A11 RID: 14865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000658")]
	public override int Hp
	{
		[Token(Token = "0x600307E")]
		[Address(RVA = "0x1E986E0", Offset = "0x1E987E1", VA = "0x1E986E0", Slot = "8")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600307F")]
		[Address(RVA = "0x1E98700", Offset = "0x1E98801", VA = "0x1E98700", Slot = "9")]
		set
		{
		}
	}

	// Token: 0x17000814 RID: 2068
	// (get) Token: 0x06003A12 RID: 14866 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A13 RID: 14867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000659")]
	public ItemData TemporaryStatus_UseItem
	{
		[Token(Token = "0x6003080")]
		[Address(RVA = "0x1E985E0", Offset = "0x1E986E1", VA = "0x1E985E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003081")]
		[Address(RVA = "0x1E98720", Offset = "0x1E98821", VA = "0x1E98720")]
		protected set
		{
		}
	}

	// Token: 0x17000815 RID: 2069
	// (get) Token: 0x06003A14 RID: 14868 RVA: 0x000141A8 File Offset: 0x000123A8
	// (set) Token: 0x06003A15 RID: 14869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700065A")]
	public int TemporaryStatus_UseItem_Time
	{
		[Token(Token = "0x6003082")]
		[Address(RVA = "0x1E98740", Offset = "0x1E98841", VA = "0x1E98740")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003083")]
		[Address(RVA = "0x1E98760", Offset = "0x1E98861", VA = "0x1E98760")]
		protected set
		{
		}
	}

	// Token: 0x17000816 RID: 2070
	// (get) Token: 0x06003A16 RID: 14870 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A17 RID: 14871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700065B")]
	private protected TimeManager.JustTimerData TemporaryStatus_UseItem_Handle
	{
		[Token(Token = "0x6003084")]
		[Address(RVA = "0x1E98780", Offset = "0x1E98881", VA = "0x1E98780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6030", Offset = "0x1A6131")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6003085")]
		[Address(RVA = "0x1E98790", Offset = "0x1E98891", VA = "0x1E98790")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6040", Offset = "0x1A6141")]
		private set
		{
		}
	}

	// Token: 0x17000817 RID: 2071
	// (get) Token: 0x06003A18 RID: 14872 RVA: 0x000141C0 File Offset: 0x000123C0
	// (set) Token: 0x06003A19 RID: 14873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700065C")]
	public HotSpringID TemporaryStatus_HotSpring
	{
		[Token(Token = "0x6003086")]
		[Address(RVA = "0x1E98620", Offset = "0x1E98721", VA = "0x1E98620")]
		get
		{
			return HotSpringID.EMPTY;
		}
		[Token(Token = "0x6003087")]
		[Address(RVA = "0x1E987A0", Offset = "0x1E988A1", VA = "0x1E987A0")]
		protected set
		{
		}
	}

	// Token: 0x17000818 RID: 2072
	// (get) Token: 0x06003A1A RID: 14874 RVA: 0x000141D8 File Offset: 0x000123D8
	// (set) Token: 0x06003A1B RID: 14875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700065D")]
	public int TemporaryStatus_HotSpring_Time
	{
		[Token(Token = "0x6003088")]
		[Address(RVA = "0x1E987C0", Offset = "0x1E988C1", VA = "0x1E987C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003089")]
		[Address(RVA = "0x1E987E0", Offset = "0x1E988E1", VA = "0x1E987E0")]
		protected set
		{
		}
	}

	// Token: 0x17000819 RID: 2073
	// (get) Token: 0x06003A1C RID: 14876 RVA: 0x000141F0 File Offset: 0x000123F0
	// (set) Token: 0x06003A1D RID: 14877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700065E")]
	public int TemporaryStatus_HotSpring_End_Time
	{
		[Token(Token = "0x600308A")]
		[Address(RVA = "0x1E98800", Offset = "0x1E98901", VA = "0x1E98800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6050", Offset = "0x1A6151")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600308B")]
		[Address(RVA = "0x1E98810", Offset = "0x1E98911", VA = "0x1E98810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6060", Offset = "0x1A6161")]
		protected set
		{
		}
	}

	// Token: 0x1700081A RID: 2074
	// (get) Token: 0x06003A1E RID: 14878 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A1F RID: 14879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700065F")]
	private protected TimeManager.JustTimerData TemporaryStatus_HotSpring_Handle
	{
		[Token(Token = "0x600308C")]
		[Address(RVA = "0x1E98820", Offset = "0x1E98921", VA = "0x1E98820")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6070", Offset = "0x1A6171")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x600308D")]
		[Address(RVA = "0x1E98830", Offset = "0x1E98931", VA = "0x1E98830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6080", Offset = "0x1A6181")]
		private set
		{
		}
	}

	// Token: 0x1700081B RID: 2075
	// (get) Token: 0x06003A20 RID: 14880 RVA: 0x00014208 File Offset: 0x00012408
	// (set) Token: 0x06003A21 RID: 14881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000660")]
	public VaccinationID TemporaryStatus_Vaccination
	{
		[Token(Token = "0x600308E")]
		[Address(RVA = "0x1E98600", Offset = "0x1E98701", VA = "0x1E98600")]
		get
		{
			return VaccinationID.EMPTY;
		}
		[Token(Token = "0x600308F")]
		[Address(RVA = "0x1E98840", Offset = "0x1E98941", VA = "0x1E98840")]
		protected set
		{
		}
	}

	// Token: 0x1700081C RID: 2076
	// (get) Token: 0x06003A22 RID: 14882 RVA: 0x00014220 File Offset: 0x00012420
	// (set) Token: 0x06003A23 RID: 14883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000661")]
	public int TemporaryStatus_Vaccination_Time
	{
		[Token(Token = "0x6003090")]
		[Address(RVA = "0x1E98860", Offset = "0x1E98961", VA = "0x1E98860")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003091")]
		[Address(RVA = "0x1E98880", Offset = "0x1E98981", VA = "0x1E98880")]
		protected set
		{
		}
	}

	// Token: 0x1700081D RID: 2077
	// (get) Token: 0x06003A24 RID: 14884 RVA: 0x00014238 File Offset: 0x00012438
	// (set) Token: 0x06003A25 RID: 14885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000662")]
	public int TemporaryStatus_Vaccination_End_Time
	{
		[Token(Token = "0x6003092")]
		[Address(RVA = "0x1E988A0", Offset = "0x1E989A1", VA = "0x1E988A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6090", Offset = "0x1A6191")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003093")]
		[Address(RVA = "0x1E988B0", Offset = "0x1E989B1", VA = "0x1E988B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A60A0", Offset = "0x1A61A1")]
		protected set
		{
		}
	}

	// Token: 0x1700081E RID: 2078
	// (get) Token: 0x06003A26 RID: 14886 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A27 RID: 14887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000663")]
	private protected TimeManager.JustTimerData TemporaryStatus_Vaccination_Handle
	{
		[Token(Token = "0x6003094")]
		[Address(RVA = "0x1E988C0", Offset = "0x1E989C1", VA = "0x1E988C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A60B0", Offset = "0x1A61B1")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6003095")]
		[Address(RVA = "0x1E988D0", Offset = "0x1E989D1", VA = "0x1E988D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A60C0", Offset = "0x1A61C1")]
		private set
		{
		}
	}

	// Token: 0x1700081F RID: 2079
	// (get) Token: 0x06003A28 RID: 14888 RVA: 0x00014250 File Offset: 0x00012450
	[Token(Token = "0x17000664")]
	public bool IsScore_ATKUp
	{
		[Token(Token = "0x6003096")]
		[Address(RVA = "0x1E988E0", Offset = "0x1E989E1", VA = "0x1E988E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000820 RID: 2080
	// (get) Token: 0x06003A29 RID: 14889 RVA: 0x00014268 File Offset: 0x00012468
	// (set) Token: 0x06003A2A RID: 14890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000665")]
	public int Score_ATKUp_End_Time
	{
		[Token(Token = "0x6003097")]
		[Address(RVA = "0x1E98910", Offset = "0x1E98A11", VA = "0x1E98910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A60D0", Offset = "0x1A61D1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003098")]
		[Address(RVA = "0x1E98920", Offset = "0x1E98A21", VA = "0x1E98920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A60E0", Offset = "0x1A61E1")]
		protected set
		{
		}
	}

	// Token: 0x17000821 RID: 2081
	// (get) Token: 0x06003A2B RID: 14891 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A2C RID: 14892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000666")]
	private protected TimeManager.JustTimerData Score_ATKUp_Handle
	{
		[Token(Token = "0x6003099")]
		[Address(RVA = "0x1E98930", Offset = "0x1E98A31", VA = "0x1E98930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A60F0", Offset = "0x1A61F1")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x600309A")]
		[Address(RVA = "0x1E98940", Offset = "0x1E98A41", VA = "0x1E98940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6100", Offset = "0x1A6201")]
		private set
		{
		}
	}

	// Token: 0x17000822 RID: 2082
	// (get) Token: 0x06003A2D RID: 14893 RVA: 0x00014280 File Offset: 0x00012480
	[Token(Token = "0x17000667")]
	public bool IsScore_DEFUp
	{
		[Token(Token = "0x600309B")]
		[Address(RVA = "0x1E98950", Offset = "0x1E98A51", VA = "0x1E98950")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000823 RID: 2083
	// (get) Token: 0x06003A2E RID: 14894 RVA: 0x00014298 File Offset: 0x00012498
	// (set) Token: 0x06003A2F RID: 14895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000668")]
	public int Score_DEFUp_End_Time
	{
		[Token(Token = "0x600309C")]
		[Address(RVA = "0x1E98980", Offset = "0x1E98A81", VA = "0x1E98980")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6110", Offset = "0x1A6211")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600309D")]
		[Address(RVA = "0x1E98990", Offset = "0x1E98A91", VA = "0x1E98990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6120", Offset = "0x1A6221")]
		protected set
		{
		}
	}

	// Token: 0x17000824 RID: 2084
	// (get) Token: 0x06003A30 RID: 14896 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003A31 RID: 14897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000669")]
	private protected TimeManager.JustTimerData Score_DEFUp_Handle
	{
		[Token(Token = "0x600309E")]
		[Address(RVA = "0x1E989A0", Offset = "0x1E98AA1", VA = "0x1E989A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6130", Offset = "0x1A6231")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x600309F")]
		[Address(RVA = "0x1E989B0", Offset = "0x1E98AB1", VA = "0x1E989B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6140", Offset = "0x1A6241")]
		private set
		{
		}
	}

	// Token: 0x17000825 RID: 2085
	// (get) Token: 0x06003A32 RID: 14898 RVA: 0x000142B0 File Offset: 0x000124B0
	// (set) Token: 0x06003A33 RID: 14899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700066A")]
	public int Rp
	{
		[Token(Token = "0x60030A0")]
		[Address(RVA = "0x1E97450", Offset = "0x1E97551", VA = "0x1E97450")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60030A1")]
		[Address(RVA = "0x1E97470", Offset = "0x1E97571", VA = "0x1E97470")]
		set
		{
		}
	}

	// Token: 0x17000826 RID: 2086
	// (get) Token: 0x06003A34 RID: 14900 RVA: 0x000142C8 File Offset: 0x000124C8
	// (set) Token: 0x06003A35 RID: 14901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700066B")]
	public float StunGage
	{
		[Token(Token = "0x60030A2")]
		[Address(RVA = "0x1E989C0", Offset = "0x1E98AC1", VA = "0x1E989C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6150", Offset = "0x1A6251")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60030A3")]
		[Address(RVA = "0x1E989D0", Offset = "0x1E98AD1", VA = "0x1E989D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6160", Offset = "0x1A6261")]
		protected set
		{
		}
	}

	// Token: 0x17000827 RID: 2087
	// (get) Token: 0x06003A36 RID: 14902 RVA: 0x000142E0 File Offset: 0x000124E0
	[Token(Token = "0x1700066C")]
	private float DecreaseStunGagePerSec
	{
		[Token(Token = "0x60030A4")]
		[Address(RVA = "0x1E989E0", Offset = "0x1E98AE1", VA = "0x1E989E0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000828 RID: 2088
	// (get) Token: 0x06003A37 RID: 14903 RVA: 0x000142F8 File Offset: 0x000124F8
	// (set) Token: 0x06003A38 RID: 14904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700066D")]
	private float PoisonTimer
	{
		[Token(Token = "0x60030A5")]
		[Address(RVA = "0x1E989F0", Offset = "0x1E98AF1", VA = "0x1E989F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6170", Offset = "0x1A6271")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60030A6")]
		[Address(RVA = "0x1E98A00", Offset = "0x1E98B01", VA = "0x1E98A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6180", Offset = "0x1A6281")]
		set
		{
		}
	}

	// Token: 0x17000829 RID: 2089
	// (get) Token: 0x06003A39 RID: 14905 RVA: 0x00014310 File Offset: 0x00012510
	// (set) Token: 0x06003A3A RID: 14906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700066E")]
	private float SickTimer
	{
		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x1E98A10", Offset = "0x1E98B11", VA = "0x1E98A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6190", Offset = "0x1A6291")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x1E98A20", Offset = "0x1E98B21", VA = "0x1E98A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A61A0", Offset = "0x1A62A1")]
		set
		{
		}
	}

	// Token: 0x1700082A RID: 2090
	// (get) Token: 0x06003A3B RID: 14907 RVA: 0x00014328 File Offset: 0x00012528
	// (set) Token: 0x06003A3C RID: 14908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700066F")]
	private float StunTimer
	{
		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x1E98A30", Offset = "0x1E98B31", VA = "0x1E98A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A61B0", Offset = "0x1A62B1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x1E98A40", Offset = "0x1E98B41", VA = "0x1E98A40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A61C0", Offset = "0x1A62C1")]
		set
		{
		}
	}

	// Token: 0x1700082B RID: 2091
	// (get) Token: 0x06003A3D RID: 14909 RVA: 0x00014340 File Offset: 0x00012540
	// (set) Token: 0x06003A3E RID: 14910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000670")]
	private float SleepTimer
	{
		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x1E98A50", Offset = "0x1E98B51", VA = "0x1E98A50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A61D0", Offset = "0x1A62D1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60030AC")]
		[Address(RVA = "0x1E98A60", Offset = "0x1E98B61", VA = "0x1E98A60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A61E0", Offset = "0x1A62E1")]
		set
		{
		}
	}

	// Token: 0x1700082C RID: 2092
	// (get) Token: 0x06003A3F RID: 14911 RVA: 0x00014358 File Offset: 0x00012558
	[Token(Token = "0x17000671")]
	public bool IsKnockback
	{
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x1E98A70", Offset = "0x1E98B71", VA = "0x1E98A70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700082D RID: 2093
	// (get) Token: 0x06003A40 RID: 14912 RVA: 0x00014370 File Offset: 0x00012570
	// (set) Token: 0x06003A41 RID: 14913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000672")]
	public float CurrentKnockbackTimer
	{
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x1E98A80", Offset = "0x1E98B81", VA = "0x1E98A80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A61F0", Offset = "0x1A62F1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x1E98A90", Offset = "0x1E98B91", VA = "0x1E98A90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6200", Offset = "0x1A6301")]
		private set
		{
		}
	}

	// Token: 0x1700082E RID: 2094
	// (get) Token: 0x06003A42 RID: 14914 RVA: 0x00014388 File Offset: 0x00012588
	// (set) Token: 0x06003A43 RID: 14915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000673")]
	public float BlowHealCoolTime
	{
		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x1E98AA0", Offset = "0x1E98BA1", VA = "0x1E98AA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6210", Offset = "0x1A6311")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x1E98AB0", Offset = "0x1E98BB1", VA = "0x1E98AB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6220", Offset = "0x1A6321")]
		private set
		{
		}
	}

	// Token: 0x1700082F RID: 2095
	// (get) Token: 0x06003A44 RID: 14916 RVA: 0x000143A0 File Offset: 0x000125A0
	// (set) Token: 0x06003A45 RID: 14917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000674")]
	public float CurrentBlowTimer
	{
		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x1E98AC0", Offset = "0x1E98BC1", VA = "0x1E98AC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6230", Offset = "0x1A6331")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x1E98AD0", Offset = "0x1E98BD1", VA = "0x1E98AD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6240", Offset = "0x1A6341")]
		private set
		{
		}
	}

	// Token: 0x06003A46 RID: 14918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B4")]
	[Address(RVA = "0x1E98AE0", Offset = "0x1E98BE1", VA = "0x1E98AE0")]
	public void ClearBlowTimer()
	{
	}

	// Token: 0x06003A47 RID: 14919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B5")]
	[Address(RVA = "0x1E98AF0", Offset = "0x1E98BF1", VA = "0x1E98AF0", Slot = "15")]
	public virtual void UpdateStatus()
	{
	}

	// Token: 0x17000830 RID: 2096
	// (get) Token: 0x06003A48 RID: 14920
	[Token(Token = "0x17000675")]
	protected abstract float PoisonDamagePercent { [Token(Token = "0x60030B6")] get; }

	// Token: 0x06003A49 RID: 14921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B7")]
	[Address(RVA = "0x1E99290", Offset = "0x1E99391", VA = "0x1E99290")]
	private void InvokePoisonDamage()
	{
	}

	// Token: 0x06003A4A RID: 14922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B8")]
	[Address(RVA = "0x1E99990", Offset = "0x1E99A91", VA = "0x1E99990")]
	private void InvokeSickDamage()
	{
	}

	// Token: 0x06003A4B RID: 14923 RVA: 0x000143B8 File Offset: 0x000125B8
	[Token(Token = "0x60030B9")]
	[Address(RVA = "0x1E9A2B0", Offset = "0x1E9A3B1", VA = "0x1E9A2B0")]
	public DamageInfo CreateDamageInfo(AttackType attackType, float motionPower, float knockbackPower, float criticalPower, float attackStun, AttackAttribute attackAttribute)
	{
		return default(DamageInfo);
	}

	// Token: 0x06003A4C RID: 14924 RVA: 0x000143D0 File Offset: 0x000125D0
	[Token(Token = "0x60030BA")]
	[Address(RVA = "0x1E9A390", Offset = "0x1E9A491", VA = "0x1E9A390")]
	public DamageInfo CreateDamageInfoHitSystem(AttackType attackType, float motionPower, float knockbackPower, float criticalPower, float stunRate, AttackAttribute attackAttribute)
	{
		return default(DamageInfo);
	}

	// Token: 0x06003A4D RID: 14925 RVA: 0x000143E8 File Offset: 0x000125E8
	[Token(Token = "0x60030BB")]
	[Address(RVA = "0x1E9A4E0", Offset = "0x1E9A5E1", VA = "0x1E9A4E0", Slot = "17")]
	public virtual DamageInfo CreateDamageInfo(AttackType attackType, float motionPower, float knockbackPower, float criticalPower, float attackStun, AttackAttribute attackAttribute, Vector3 hitPosition)
	{
		return default(DamageInfo);
	}

	// Token: 0x06003A4E RID: 14926 RVA: 0x00014400 File Offset: 0x00012600
	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x1E9AAB0", Offset = "0x1E9ABB1", VA = "0x1E9AAB0", Slot = "18")]
	public virtual DamageInfo CreateMagicDamageInfo(MagicParamID paramID, int level)
	{
		return default(DamageInfo);
	}

	// Token: 0x06003A4F RID: 14927 RVA: 0x00014418 File Offset: 0x00012618
	[Token(Token = "0x60030BD")]
	[Address(RVA = "0x1E9AB40", Offset = "0x1E9AC41", VA = "0x1E9AB40", Slot = "19")]
	public virtual DamageInfo CreateMagicDamageInfo(MagicParamDataTable dataTable, int level)
	{
		return default(DamageInfo);
	}

	// Token: 0x06003A50 RID: 14928 RVA: 0x00014430 File Offset: 0x00012630
	[Token(Token = "0x60030BE")]
	[Address(RVA = "0x1E9AB70", Offset = "0x1E9AC71", VA = "0x1E9AB70", Slot = "11")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06003A51 RID: 14929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x1E9B610", Offset = "0x1E9B711", VA = "0x1E9B610")]
	protected void ReTimerTemporaryStatus()
	{
	}

	// Token: 0x06003A52 RID: 14930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C0")]
	[Address(RVA = "0x1E9B6D0", Offset = "0x1E9B7D1", VA = "0x1E9B6D0")]
	private void SetTemporaryStatus_UseItem(ItemData itemData, bool reTimer = false)
	{
	}

	// Token: 0x06003A53 RID: 14931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x1E9B890", Offset = "0x1E9B991", VA = "0x1E9B890")]
	public void SetTemporaryStatus_HotSpring(HotSpringID hotSpringID, bool reTimer = false)
	{
	}

	// Token: 0x06003A54 RID: 14932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C2")]
	[Address(RVA = "0x1E9BA30", Offset = "0x1E9BB31", VA = "0x1E9BA30")]
	public void SetTemporaryStatus_Vaccination(VaccinationID id, bool reTimer = false)
	{
	}

	// Token: 0x06003A55 RID: 14933 RVA: 0x00014448 File Offset: 0x00012648
	[Token(Token = "0x60030C3")]
	[Address(RVA = "0x1E9BC30", Offset = "0x1E9BD31", VA = "0x1E9BC30")]
	public bool SetScore_ATKUp(int level, bool reTimer = false)
	{
		return default(bool);
	}

	// Token: 0x06003A56 RID: 14934 RVA: 0x00014460 File Offset: 0x00012660
	[Token(Token = "0x60030C4")]
	[Address(RVA = "0x1E9BDA0", Offset = "0x1E9BEA1", VA = "0x1E9BDA0")]
	public bool SetScore_DEFUp(int level, bool reTimer = false)
	{
		return default(bool);
	}

	// Token: 0x06003A57 RID: 14935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x1E98E40", Offset = "0x1E98F41", VA = "0x1E98E40")]
	public void Heal(int healHp, bool hpPercent, int healRp, bool rpPercent, BadStatus badStatus = BadStatus.None, bool isDisplay = true)
	{
	}

	// Token: 0x06003A58 RID: 14936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x1E9BF10", Offset = "0x1E9C011", VA = "0x1E9BF10")]
	public void FullHeal(bool isDisplay = false)
	{
	}

	// Token: 0x06003A59 RID: 14937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C7")]
	[Address(RVA = "0x1E99E70", Offset = "0x1E99F71", VA = "0x1E99E70")]
	public void ReduceRp(int value, bool isDamage, bool display, bool IgnoreGamePause = false)
	{
	}

	// Token: 0x06003A5A RID: 14938 RVA: 0x00014478 File Offset: 0x00012678
	[Token(Token = "0x60030C8")]
	[Address(RVA = "0x1E9BF30", Offset = "0x1E9C031", VA = "0x1E9BF30")]
	public int AddExpWithCheckLevelup(int addExp, MonsterDataID monsterDataID = MonsterDataID.MonsterData_EMPTY)
	{
		return 0;
	}

	// Token: 0x06003A5B RID: 14939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C9")]
	[Address(RVA = "0x1E9C5F0", Offset = "0x1E9C6F1", VA = "0x1E9C5F0")]
	private void PlayLevelUpEffect()
	{
	}

	// Token: 0x06003A5C RID: 14940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030CA")]
	[Address(RVA = "0x1E9C2B0", Offset = "0x1E9C3B1", VA = "0x1E9C2B0")]
	public void LevelChangeSet(int value)
	{
	}

	// Token: 0x06003A5D RID: 14941
	[Token(Token = "0x60030CB")]
	protected abstract void LevelUp();

	// Token: 0x06003A5E RID: 14942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030CC")]
	[Address(RVA = "0x1E9C800", Offset = "0x1E9C901", VA = "0x1E9C800", Slot = "21")]
	protected virtual void LevelDown()
	{
	}

	// Token: 0x06003A5F RID: 14943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x1E97490", Offset = "0x1E97591", VA = "0x1E97490")]
	public void updateHPRP(int setHp, int setRp)
	{
	}

	// Token: 0x17000831 RID: 2097
	// (get) Token: 0x06003A60 RID: 14944 RVA: 0x00014490 File Offset: 0x00012690
	// (set) Token: 0x06003A61 RID: 14945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000676")]
	public BadStatus CurrentBadStatus
	{
		[Token(Token = "0x60030CE")]
		[Address(RVA = "0x1E99270", Offset = "0x1E99371", VA = "0x1E99270")]
		get
		{
			return BadStatus.None;
		}
		[Token(Token = "0x60030CF")]
		[Address(RVA = "0x1E9C890", Offset = "0x1E9C991", VA = "0x1E9C890")]
		private set
		{
		}
	}

	// Token: 0x06003A62 RID: 14946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D0")]
	[Address(RVA = "0x1E99A60", Offset = "0x1E99B61", VA = "0x1E99A60")]
	public void SetBadStatus(BadStatus badStatus, bool isEnable)
	{
	}

	// Token: 0x17000832 RID: 2098
	// (get) Token: 0x06003A63 RID: 14947 RVA: 0x000144A8 File Offset: 0x000126A8
	// (set) Token: 0x06003A64 RID: 14948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000677")]
	public bool IsInvisible
	{
		[Token(Token = "0x60030D1")]
		[Address(RVA = "0x1E9C8B0", Offset = "0x1E9C9B1", VA = "0x1E9C8B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6250", Offset = "0x1A6351")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60030D2")]
		[Address(RVA = "0x1E9C8C0", Offset = "0x1E9C9C1", VA = "0x1E9C8C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6260", Offset = "0x1A6361")]
		private set
		{
		}
	}

	// Token: 0x06003A65 RID: 14949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x1E8CBA0", Offset = "0x1E8CCA1", VA = "0x1E8CBA0")]
	public void SetInvisible(bool isInvisible)
	{
	}

	// Token: 0x06003A66 RID: 14950 RVA: 0x000144C0 File Offset: 0x000126C0
	[Token(Token = "0x60030D4")]
	[Address(RVA = "0x1E9C8D0", Offset = "0x1E9C9D1", VA = "0x1E9C8D0")]
	public bool UseItem(ItemData itemData, int addLove = 0)
	{
		return default(bool);
	}

	// Token: 0x06003A67 RID: 14951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D5")]
	[Address(RVA = "0x1E9D0C0", Offset = "0x1E9D1C1", VA = "0x1E9D0C0")]
	private void DispUseParamText(ref UseParameter useParameter, int healHp, int healRp)
	{
	}

	// Token: 0x06003A68 RID: 14952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D6")]
	[Address(RVA = "0x1E9D020", Offset = "0x1E9D121", VA = "0x1E9D020")]
	private void AddPersistentParameter(Parameter parameter)
	{
	}

	// Token: 0x06003A69 RID: 14953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D7")]
	[Address(RVA = "0x1E9D5D0", Offset = "0x1E9D6D1", VA = "0x1E9D5D0")]
	protected CharacterStatusBase()
	{
	}

	// Token: 0x06003A6A RID: 14954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D8")]
	[Address(RVA = "0x1E9D6E0", Offset = "0x1E9D7E1", VA = "0x1E9D6E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6270", Offset = "0x1A6371")]
	private void <SetTemporaryStatus_UseItem>b__139_0(TimeManager.JustTimerData timerData)
	{
	}

	// Token: 0x06003A6B RID: 14955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030D9")]
	[Address(RVA = "0x1E9D740", Offset = "0x1E9D841", VA = "0x1E9D740")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6280", Offset = "0x1A6381")]
	private void <SetTemporaryStatus_HotSpring>b__140_0(TimeManager.JustTimerData timerData)
	{
	}

	// Token: 0x06003A6C RID: 14956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030DA")]
	[Address(RVA = "0x1E9D7A0", Offset = "0x1E9D8A1", VA = "0x1E9D7A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6290", Offset = "0x1A6391")]
	private void <SetTemporaryStatus_Vaccination>b__141_0(TimeManager.JustTimerData timerData)
	{
	}

	// Token: 0x06003A6D RID: 14957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030DB")]
	[Address(RVA = "0x1E9D800", Offset = "0x1E9D901", VA = "0x1E9D800")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A62A0", Offset = "0x1A63A1")]
	private void <SetScore_ATKUp>b__142_0(TimeManager.JustTimerData timerData)
	{
	}

	// Token: 0x06003A6E RID: 14958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030DC")]
	[Address(RVA = "0x1E9D850", Offset = "0x1E9D951", VA = "0x1E9D850")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A62B0", Offset = "0x1A63B1")]
	private void <SetScore_DEFUp>b__143_0(TimeManager.JustTimerData timerData)
	{
	}

	// Token: 0x04007D7B RID: 32123
	[Token(Token = "0x400716D")]
	[FieldOffset(Offset = "0xF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E440", Offset = "0x16E541")]
	private StatusDataBase <StatusData>k__BackingField;

	// Token: 0x04007D7C RID: 32124
	[Token(Token = "0x400716E")]
	[FieldOffset(Offset = "0xF8")]
	protected Coroutine Coroutine;

	// Token: 0x04007D7D RID: 32125
	[Token(Token = "0x400716F")]
	[FieldOffset(Offset = "0x100")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E450", Offset = "0x16E551")]
	private TimeManager.JustTimerData <TemporaryStatus_UseItem_Handle>k__BackingField;

	// Token: 0x04007D7E RID: 32126
	[Token(Token = "0x4007170")]
	[FieldOffset(Offset = "0x108")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E460", Offset = "0x16E561")]
	private int <TemporaryStatus_HotSpring_End_Time>k__BackingField;

	// Token: 0x04007D7F RID: 32127
	[Token(Token = "0x4007171")]
	[FieldOffset(Offset = "0x110")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E470", Offset = "0x16E571")]
	private TimeManager.JustTimerData <TemporaryStatus_HotSpring_Handle>k__BackingField;

	// Token: 0x04007D80 RID: 32128
	[Token(Token = "0x4007172")]
	[FieldOffset(Offset = "0x118")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E480", Offset = "0x16E581")]
	private int <TemporaryStatus_Vaccination_End_Time>k__BackingField;

	// Token: 0x04007D81 RID: 32129
	[Token(Token = "0x4007173")]
	[FieldOffset(Offset = "0x120")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E490", Offset = "0x16E591")]
	private TimeManager.JustTimerData <TemporaryStatus_Vaccination_Handle>k__BackingField;

	// Token: 0x04007D82 RID: 32130
	[Token(Token = "0x4007174")]
	[FieldOffset(Offset = "0x128")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E4A0", Offset = "0x16E5A1")]
	private int <Score_ATKUp_End_Time>k__BackingField;

	// Token: 0x04007D83 RID: 32131
	[Token(Token = "0x4007175")]
	[FieldOffset(Offset = "0x130")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E4B0", Offset = "0x16E5B1")]
	private TimeManager.JustTimerData <Score_ATKUp_Handle>k__BackingField;

	// Token: 0x04007D84 RID: 32132
	[Token(Token = "0x4007176")]
	[FieldOffset(Offset = "0x138")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E4C0", Offset = "0x16E5C1")]
	private int <Score_DEFUp_End_Time>k__BackingField;

	// Token: 0x04007D85 RID: 32133
	[Token(Token = "0x4007177")]
	[FieldOffset(Offset = "0x140")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E4D0", Offset = "0x16E5D1")]
	private TimeManager.JustTimerData <Score_DEFUp_Handle>k__BackingField;

	// Token: 0x04007D86 RID: 32134
	[Token(Token = "0x4007178")]
	[FieldOffset(Offset = "0x148")]
	public OnUpdateStatusEvent OnUpdateStatus;

	// Token: 0x04007D87 RID: 32135
	[Token(Token = "0x4007179")]
	[FieldOffset(Offset = "0x150")]
	public OnUpdateStatusEvent OnUpdateHp;

	// Token: 0x04007D88 RID: 32136
	[Token(Token = "0x400717A")]
	[FieldOffset(Offset = "0x158")]
	public OnUpdateStatusEvent OnUpdateRp;

	// Token: 0x04007D89 RID: 32137
	[Token(Token = "0x400717B")]
	[FieldOffset(Offset = "0x160")]
	public OnWinceEvent OnWince;

	// Token: 0x04007D8A RID: 32138
	[Token(Token = "0x400717C")]
	[FieldOffset(Offset = "0x168")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E4E0", Offset = "0x16E5E1")]
	private float <StunGage>k__BackingField;

	// Token: 0x04007D8B RID: 32139
	[Token(Token = "0x400717D")]
	private const float REGENE_TIMER = 2.11666656f;

	// Token: 0x04007D8C RID: 32140
	[Token(Token = "0x400717E")]
	[FieldOffset(Offset = "0x16C")]
	private float HpHealTimer;

	// Token: 0x04007D8D RID: 32141
	[Token(Token = "0x400717F")]
	[FieldOffset(Offset = "0x170")]
	private float RpHealTimer;

	// Token: 0x04007D8E RID: 32142
	[Token(Token = "0x4007180")]
	[FieldOffset(Offset = "0x174")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E4F0", Offset = "0x16E5F1")]
	private float <PoisonTimer>k__BackingField;

	// Token: 0x04007D8F RID: 32143
	[Token(Token = "0x4007181")]
	[FieldOffset(Offset = "0x178")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E500", Offset = "0x16E601")]
	private float <SickTimer>k__BackingField;

	// Token: 0x04007D90 RID: 32144
	[Token(Token = "0x4007182")]
	[FieldOffset(Offset = "0x17C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E510", Offset = "0x16E611")]
	private float <StunTimer>k__BackingField;

	// Token: 0x04007D91 RID: 32145
	[Token(Token = "0x4007183")]
	[FieldOffset(Offset = "0x180")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E520", Offset = "0x16E621")]
	private float <SleepTimer>k__BackingField;

	// Token: 0x04007D92 RID: 32146
	[Token(Token = "0x4007184")]
	[FieldOffset(Offset = "0x184")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E530", Offset = "0x16E631")]
	private float <CurrentKnockbackTimer>k__BackingField;

	// Token: 0x04007D93 RID: 32147
	[Token(Token = "0x4007185")]
	[FieldOffset(Offset = "0x188")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E540", Offset = "0x16E641")]
	private float <BlowHealCoolTime>k__BackingField;

	// Token: 0x04007D94 RID: 32148
	[Token(Token = "0x4007186")]
	[FieldOffset(Offset = "0x18C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E550", Offset = "0x16E651")]
	private float <CurrentBlowTimer>k__BackingField;

	// Token: 0x04007D95 RID: 32149
	[Token(Token = "0x4007187")]
	[FieldOffset(Offset = "0x190")]
	public HUDBadStatusIconDisp HUDBadStatusIconDisp;

	// Token: 0x04007D96 RID: 32150
	[Token(Token = "0x4007188")]
	[FieldOffset(Offset = "0x198")]
	private DamageInfo PoisonDamageInfo;

	// Token: 0x04007D97 RID: 32151
	[Token(Token = "0x4007189")]
	[FieldOffset(Offset = "0x218")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E560", Offset = "0x16E661")]
	private bool <IsInvisible>k__BackingField;
}
