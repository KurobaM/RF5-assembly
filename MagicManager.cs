using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000283 RID: 643
[Token(Token = "0x20001FE")]
public class MagicManager : SingletonMonoBehaviour<MagicManager>
{
	// Token: 0x06001037 RID: 4151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x1F12C10", Offset = "0x1F12D11", VA = "0x1F12C10", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x000076C8 File Offset: 0x000058C8
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x1F12E30", Offset = "0x1F12F31", VA = "0x1F12E30")]
	public bool Regist(CharacterBase chara, MagicController controller)
	{
		return default(bool);
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x000076E0 File Offset: 0x000058E0
	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0x1F12EA0", Offset = "0x1F12FA1", VA = "0x1F12EA0")]
	public bool Remove(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x1F12F10", Offset = "0x1F13011", VA = "0x1F12F10")]
	public MagicController Get(CharacterBase chara)
	{
		return null;
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x1F12FC0", Offset = "0x1F130C1", VA = "0x1F12FC0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x1F13220", Offset = "0x1F13321", VA = "0x1F13220")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x1F13380", Offset = "0x1F13481", VA = "0x1F13380")]
	private void Update()
	{
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x1F12CE0", Offset = "0x1F12DE1", VA = "0x1F12CE0")]
	public AS_MagicController CreateSpawner()
	{
		return null;
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x1F134A0", Offset = "0x1F135A1", VA = "0x1F134A0")]
	public AS_MagicController GetStoppedSpawner()
	{
		return null;
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x000076F8 File Offset: 0x000058F8
	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x1F13680", Offset = "0x1F13781", VA = "0x1F13680")]
	public bool Play(CharacterBase chara, MagicID magicID, int level, AttackAttribute attribute, Vector3 offset)
	{
		return default(bool);
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00007710 File Offset: 0x00005910
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x1F13800", Offset = "0x1F13901", VA = "0x1F13800")]
	public bool DoStop(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x00007728 File Offset: 0x00005928
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x1F12A50", Offset = "0x1F12B51", VA = "0x1F12A50")]
	public bool IsPlaying(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x1F13930", Offset = "0x1F13A31", VA = "0x1F13930")]
	public List<Collider> GetTargets(CharacterBase chara)
	{
		return null;
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x1F12FD0", Offset = "0x1F130D1", VA = "0x1F12FD0")]
	public void DoStopAll()
	{
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x00007740 File Offset: 0x00005940
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x1F13A40", Offset = "0x1F13B41", VA = "0x1F13A40")]
	public bool AddBullet(CharacterBase chara, BulletBase bullet)
	{
		return default(bool);
	}

	// Token: 0x06001046 RID: 4166 RVA: 0x00007758 File Offset: 0x00005958
	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x1F13B70", Offset = "0x1F13C71", VA = "0x1F13B70")]
	public bool StartBulletExtension(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x00007770 File Offset: 0x00005970
	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0x1F13C90", Offset = "0x1F13D91", VA = "0x1F13C90")]
	public bool StopBulletExtension(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0x1F13DB0", Offset = "0x1F13EB1", VA = "0x1F13DB0")]
	public MagicManager()
	{
	}

	// Token: 0x0400092A RID: 2346
	[Token(Token = "0x4000738")]
	private const int MagicSpawnerDefaultNum = 8;

	// Token: 0x0400092B RID: 2347
	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<AS_MagicController> m_SpawnerList;

	// Token: 0x0400092C RID: 2348
	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x20")]
	private Register<CharacterBase, MagicController> m_Register;
}
