using System;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200059F RID: 1439
[Token(Token = "0x2000401")]
public class TeleportDragonRope : PlayerTeleportButton
{
	// Token: 0x170005CB RID: 1483
	// (get) Token: 0x06002362 RID: 9058 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
	// (set) Token: 0x06002363 RID: 9059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700049D")]
	public bool IsEnable
	{
		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0x1F69EA0", Offset = "0x1F69FA1", VA = "0x1F69EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A11D0", Offset = "0x1A12D1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x1F69EB0", Offset = "0x1F69FB1", VA = "0x1F69EB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A11E0", Offset = "0x1A12E1")]
		private set
		{
		}
	}

	// Token: 0x06002364 RID: 9060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0x1F69EC0", Offset = "0x1F69FC1", VA = "0x1F69EC0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002365 RID: 9061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0x1F69FB0", Offset = "0x1F6A0B1", VA = "0x1F69FB0")]
	public new void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAC")]
	[Address(RVA = "0x1F6A090", Offset = "0x1F6A191", VA = "0x1F6A090", Slot = "21")]
	protected override void Awake()
	{
	}

	// Token: 0x06002367 RID: 9063 RVA: 0x0000E610 File Offset: 0x0000C810
	[Token(Token = "0x6001DAD")]
	[Address(RVA = "0x1F69FE0", Offset = "0x1F6A0E1", VA = "0x1F69FE0")]
	private bool CheckRopeEnable()
	{
		return default(bool);
	}

	// Token: 0x06002368 RID: 9064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAE")]
	[Address(RVA = "0x1F6A2D0", Offset = "0x1F6A3D1", VA = "0x1F6A2D0", Slot = "20")]
	protected override void OnTriggerEnter(Collider collision)
	{
	}

	// Token: 0x06002369 RID: 9065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAF")]
	[Address(RVA = "0x1F6A370", Offset = "0x1F6A471", VA = "0x1F6A370", Slot = "23")]
	protected override void TeleportScene()
	{
	}

	// Token: 0x0600236A RID: 9066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0x1F65FA0", Offset = "0x1F660A1", VA = "0x1F65FA0")]
	public void UpdateTeleportPoint()
	{
	}

	// Token: 0x0600236B RID: 9067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0x1F6A380", Offset = "0x1F6A481", VA = "0x1F6A380")]
	public TeleportDragonRope()
	{
	}

	// Token: 0x04006B1C RID: 27420
	[Token(Token = "0x4006473")]
	[FieldOffset(Offset = "0x99")]
	public bool IsRopeField;

	// Token: 0x04006B1D RID: 27421
	[Token(Token = "0x4006474")]
	[FieldOffset(Offset = "0x9A")]
	public bool IsRopeFarm;

	// Token: 0x04006B1E RID: 27422
	[Token(Token = "0x4006475")]
	[FieldOffset(Offset = "0x9C")]
	public int FieldPlaceId;

	// Token: 0x04006B1F RID: 27423
	[Token(Token = "0x4006476")]
	[FieldOffset(Offset = "0xA0")]
	public int FarmPlaceId;

	// Token: 0x04006B20 RID: 27424
	[Token(Token = "0x4006477")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1668D0", Offset = "0x1669D1")]
	private bool <IsEnable>k__BackingField;

	// Token: 0x04006B21 RID: 27425
	[Token(Token = "0x4006478")]
	[FieldOffset(Offset = "0xA8")]
	public Transform RopeMoveRoot;

	// Token: 0x04006B22 RID: 27426
	[Token(Token = "0x4006479")]
	[FieldOffset(Offset = "0xB0")]
	private FieldSceneData.Data SceneData;
}
