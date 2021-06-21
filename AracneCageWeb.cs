using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006A7 RID: 1703
[Token(Token = "0x20004C8")]
public class AracneCageWeb : MonoBehaviour
{
	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x06002971 RID: 10609 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002972 RID: 10610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700053C")]
	public Character CatchCharacter
	{
		[Token(Token = "0x6002308")]
		[Address(RVA = "0x2437E30", Offset = "0x2437F31", VA = "0x2437E30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2340", Offset = "0x1A2441")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002309")]
		[Address(RVA = "0x2437E40", Offset = "0x2437F41", VA = "0x2437E40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2350", Offset = "0x1A2451")]
		private set
		{
		}
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600230A")]
	[Address(RVA = "0x2437E50", Offset = "0x2437F51", VA = "0x2437E50")]
	private void Start()
	{
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600230B")]
	[Address(RVA = "0x2437F60", Offset = "0x2438061", VA = "0x2437F60")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600230C")]
	[Address(RVA = "0x2438090", Offset = "0x2438191", VA = "0x2438090")]
	private void Update()
	{
	}

	// Token: 0x06002976 RID: 10614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600230D")]
	[Address(RVA = "0x2438620", Offset = "0x2438721", VA = "0x2438620")]
	private void Catch(Character character)
	{
	}

	// Token: 0x06002977 RID: 10615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600230E")]
	[Address(RVA = "0x2438220", Offset = "0x2438321", VA = "0x2438220")]
	private void Gatya()
	{
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600230F")]
	[Address(RVA = "0x24383E0", Offset = "0x24384E1", VA = "0x24383E0")]
	private void Break()
	{
	}

	// Token: 0x06002979 RID: 10617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002310")]
	[Address(RVA = "0x2438460", Offset = "0x2438561", VA = "0x2438460")]
	public void End()
	{
	}

	// Token: 0x0600297A RID: 10618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002311")]
	[Address(RVA = "0x2438790", Offset = "0x2438891", VA = "0x2438790")]
	private void RideOn(MonsterControllerBase monster)
	{
	}

	// Token: 0x0600297B RID: 10619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002312")]
	[Address(RVA = "0x24388B0", Offset = "0x24389B1", VA = "0x24388B0")]
	private void RideEnd(MonsterControllerBase monster)
	{
	}

	// Token: 0x0600297C RID: 10620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002313")]
	[Address(RVA = "0x2438940", Offset = "0x2438A41", VA = "0x2438940")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600297D RID: 10621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002314")]
	[Address(RVA = "0x2438C00", Offset = "0x2438D01", VA = "0x2438C00")]
	public AracneCageWeb()
	{
	}

	// Token: 0x0400719F RID: 29087
	[Token(Token = "0x4006993")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float DestoryTime;

	// Token: 0x040071A0 RID: 29088
	[Token(Token = "0x4006994")]
	[FieldOffset(Offset = "0x1C")]
	private float ElapasedTimer;

	// Token: 0x040071A1 RID: 29089
	[Token(Token = "0x4006995")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float CatchTime;

	// Token: 0x040071A2 RID: 29090
	[Token(Token = "0x4006996")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int LeverGatyaMax;

	// Token: 0x040071A3 RID: 29091
	[Token(Token = "0x4006997")]
	[FieldOffset(Offset = "0x28")]
	private int LeverGatyaCounter;

	// Token: 0x040071A4 RID: 29092
	[Token(Token = "0x4006998")]
	[FieldOffset(Offset = "0x2C")]
	private bool IsCtrlChara;

	// Token: 0x040071A5 RID: 29093
	[Token(Token = "0x4006999")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169440", Offset = "0x169541")]
	private Character <CatchCharacter>k__BackingField;

	// Token: 0x040071A6 RID: 29094
	[Token(Token = "0x400699A")]
	[FieldOffset(Offset = "0x38")]
	private bool IsBreak;

	// Token: 0x040071A7 RID: 29095
	[Token(Token = "0x400699B")]
	[FieldOffset(Offset = "0x40")]
	public Action EndCallback;

	// Token: 0x040071A8 RID: 29096
	[Token(Token = "0x400699C")]
	[FieldOffset(Offset = "0x48")]
	public Alliance Alliance;

	// Token: 0x040071A9 RID: 29097
	[Token(Token = "0x400699D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ParticleSystem StartEffect;

	// Token: 0x040071AA RID: 29098
	[Token(Token = "0x400699E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ParticleSystem LoopEffect;

	// Token: 0x040071AB RID: 29099
	[Token(Token = "0x400699F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ParticleSystem BreakLoopEffect;

	// Token: 0x040071AC RID: 29100
	[Token(Token = "0x40069A0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ParticleSystem EndEffect;

	// Token: 0x040071AD RID: 29101
	[Token(Token = "0x40069A1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ParticleSystem GatyaEffect;
}
