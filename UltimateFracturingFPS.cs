using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B78 RID: 2936
[Token(Token = "0x20007A4")]
public class UltimateFracturingFPS : MonoBehaviour
{
	// Token: 0x06004B63 RID: 19299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F2E")]
	[Address(RVA = "0x20FCCD0", Offset = "0x20FCDD1", VA = "0x20FCCD0")]
	private void Start()
	{
	}

	// Token: 0x06004B64 RID: 19300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F2F")]
	[Address(RVA = "0x20FCDB0", Offset = "0x20FCEB1", VA = "0x20FCDB0")]
	private void OnGUI()
	{
	}

	// Token: 0x06004B65 RID: 19301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F30")]
	[Address(RVA = "0x20FD000", Offset = "0x20FD101", VA = "0x20FD000")]
	private void Update()
	{
	}

	// Token: 0x06004B66 RID: 19302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F31")]
	[Address(RVA = "0x20FD830", Offset = "0x20FD931", VA = "0x20FD830")]
	public UltimateFracturingFPS()
	{
	}

	// Token: 0x0400ABFB RID: 44027
	[Token(Token = "0x40081BA")]
	[FieldOffset(Offset = "0x18")]
	public UltimateFracturingFPS.Mode ShootMode;

	// Token: 0x0400ABFC RID: 44028
	[Token(Token = "0x40081BB")]
	[FieldOffset(Offset = "0x1C")]
	public float MouseSpeed;

	// Token: 0x0400ABFD RID: 44029
	[Token(Token = "0x40081BC")]
	[FieldOffset(Offset = "0x20")]
	public Texture HUDTexture;

	// Token: 0x0400ABFE RID: 44030
	[Token(Token = "0x40081BD")]
	[FieldOffset(Offset = "0x28")]
	public float HUDSize;

	// Token: 0x0400ABFF RID: 44031
	[Token(Token = "0x40081BE")]
	[FieldOffset(Offset = "0x2C")]
	public Color HUDColorNormal;

	// Token: 0x0400AC00 RID: 44032
	[Token(Token = "0x40081BF")]
	[FieldOffset(Offset = "0x3C")]
	public Color HUDColorRaycast;

	// Token: 0x0400AC01 RID: 44033
	[Token(Token = "0x40081C0")]
	[FieldOffset(Offset = "0x50")]
	public Transform Weapon;

	// Token: 0x0400AC02 RID: 44034
	[Token(Token = "0x40081C1")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip AudioWeaponShot;

	// Token: 0x0400AC03 RID: 44035
	[Token(Token = "0x40081C2")]
	[FieldOffset(Offset = "0x60")]
	public float WeaponShotVolume;

	// Token: 0x0400AC04 RID: 44036
	[Token(Token = "0x40081C3")]
	[FieldOffset(Offset = "0x64")]
	public float ExplosionForce;

	// Token: 0x0400AC05 RID: 44037
	[Token(Token = "0x40081C4")]
	[FieldOffset(Offset = "0x68")]
	public float ExplosionRadius;

	// Token: 0x0400AC06 RID: 44038
	[Token(Token = "0x40081C5")]
	[FieldOffset(Offset = "0x6C")]
	public float RecoilDuration;

	// Token: 0x0400AC07 RID: 44039
	[Token(Token = "0x40081C6")]
	[FieldOffset(Offset = "0x70")]
	public float RecoilIntensity;

	// Token: 0x0400AC08 RID: 44040
	[Token(Token = "0x40081C7")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ObjectToShoot;

	// Token: 0x0400AC09 RID: 44041
	[Token(Token = "0x40081C8")]
	[FieldOffset(Offset = "0x80")]
	public float InitialObjectSpeed;

	// Token: 0x0400AC0A RID: 44042
	[Token(Token = "0x40081C9")]
	[FieldOffset(Offset = "0x84")]
	public float ObjectScale;

	// Token: 0x0400AC0B RID: 44043
	[Token(Token = "0x40081CA")]
	[FieldOffset(Offset = "0x88")]
	public float ObjectMass;

	// Token: 0x0400AC0C RID: 44044
	[Token(Token = "0x40081CB")]
	[FieldOffset(Offset = "0x8C")]
	public float ObjectLife;

	// Token: 0x0400AC0D RID: 44045
	[Token(Token = "0x40081CC")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 m_v3MousePosition;

	// Token: 0x0400AC0E RID: 44046
	[Token(Token = "0x40081CD")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_bRaycastFound;

	// Token: 0x0400AC0F RID: 44047
	[Token(Token = "0x40081CE")]
	[FieldOffset(Offset = "0xA0")]
	private float m_fRecoilTimer;

	// Token: 0x0400AC10 RID: 44048
	[Token(Token = "0x40081CF")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 m_v3InitialWeaponPos;

	// Token: 0x0400AC11 RID: 44049
	[Token(Token = "0x40081D0")]
	[FieldOffset(Offset = "0xB0")]
	private Quaternion m_qInitialWeaponRot;

	// Token: 0x02000B79 RID: 2937
	[Token(Token = "0x2001355")]
	public enum Mode
	{
		// Token: 0x0400AC13 RID: 44051
		[Token(Token = "0x401B6A3")]
		ShootObjects,
		// Token: 0x0400AC14 RID: 44052
		[Token(Token = "0x401B6A4")]
		ExplodeRaycast
	}
}
