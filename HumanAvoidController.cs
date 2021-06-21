using System;
using Il2CppDummyDll;

// Token: 0x0200022F RID: 559
[Token(Token = "0x20001C1")]
public class HumanAvoidController : CharaAvoidController<HumanController>
{
	// Token: 0x1700027E RID: 638
	// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700025E")]
	private CharacterMoveSetting Setting
	{
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x2093DF0", Offset = "0x2093EF1", VA = "0x2093DF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x00006270 File Offset: 0x00004470
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x2093E60", Offset = "0x2093F61", VA = "0x2093E60", Slot = "5")]
	public override bool DoPlay()
	{
		return default(bool);
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x2094870", Offset = "0x2094971", VA = "0x2094870", Slot = "8")]
	public override void OnUpdate()
	{
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x20948E0", Offset = "0x20949E1", VA = "0x20948E0")]
	public HumanAvoidController()
	{
	}

	// Token: 0x040007AA RID: 1962
	[Token(Token = "0x4000637")]
	private const int RipplesNum = 3;

	// Token: 0x040007AB RID: 1963
	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x0")]
	private static float[] m_RipplesDistance;

	// Token: 0x040007AC RID: 1964
	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x8")]
	private static float[] m_RipplesSpeed;
}
