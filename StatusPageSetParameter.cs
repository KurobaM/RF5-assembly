using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A47 RID: 2631
[Token(Token = "0x20006EB")]
public class StatusPageSetParameter : MonoBehaviour
{
	// Token: 0x060044BA RID: 17594 RVA: 0x00016D70 File Offset: 0x00014F70
	[Token(Token = "0x6003997")]
	[Address(RVA = "0x238AE20", Offset = "0x238AF21", VA = "0x238AE20")]
	private Parameter GetParameter(ActorID actorID)
	{
		return default(Parameter);
	}

	// Token: 0x060044BB RID: 17595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003998")]
	[Address(RVA = "0x238AE60", Offset = "0x238AF61", VA = "0x238AE60")]
	private void SetParameter()
	{
	}

	// Token: 0x060044BC RID: 17596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003999")]
	[Address(RVA = "0x238B4B0", Offset = "0x238B5B1", VA = "0x238B4B0")]
	private void OnEnable()
	{
	}

	// Token: 0x060044BD RID: 17597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600399A")]
	[Address(RVA = "0x238B4C0", Offset = "0x238B5C1", VA = "0x238B4C0")]
	public StatusPageSetParameter()
	{
	}

	// Token: 0x0400A397 RID: 41879
	[Token(Token = "0x4007BBB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text NameText;

	// Token: 0x0400A398 RID: 41880
	[Token(Token = "0x4007BBC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text LvText;

	// Token: 0x0400A399 RID: 41881
	[Token(Token = "0x4007BBD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text ExpNextText;

	// Token: 0x0400A39A RID: 41882
	[Token(Token = "0x4007BBE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image ExpGauge;

	// Token: 0x0400A39B RID: 41883
	[Token(Token = "0x4007BBF")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text HpText;

	// Token: 0x0400A39C RID: 41884
	[Token(Token = "0x4007BC0")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image HpGauge;

	// Token: 0x0400A39D RID: 41885
	[Token(Token = "0x4007BC1")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text RpText;

	// Token: 0x0400A39E RID: 41886
	[Token(Token = "0x4007BC2")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image RpGauge;

	// Token: 0x0400A39F RID: 41887
	[Token(Token = "0x4007BC3")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text MoneyText;

	// Token: 0x0400A3A0 RID: 41888
	[Token(Token = "0x4007BC4")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text SeedPointText;

	// Token: 0x0400A3A1 RID: 41889
	[Token(Token = "0x4007BC5")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text StoneText;

	// Token: 0x0400A3A2 RID: 41890
	[Token(Token = "0x4007BC6")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text LumberText;

	// Token: 0x0400A3A3 RID: 41891
	[Token(Token = "0x4007BC7")]
	private const int ElementMax = 7;

	// Token: 0x0400A3A4 RID: 41892
	[Token(Token = "0x4007BC8")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private StatusPageSetParameter.ElementParameterText[] ElementText;

	// Token: 0x02000A48 RID: 2632
	[Token(Token = "0x20012DE")]
	[Serializable]
	private struct ElementParameterText
	{
		// Token: 0x0400A3A5 RID: 41893
		[Token(Token = "0x401B43F")]
		[FieldOffset(Offset = "0x0")]
		public Text Def;
	}
}
