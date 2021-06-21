using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000268 RID: 616
[Token(Token = "0x20001EA")]
public class ActorVoiceManager : SingletonMonoBehaviour<ActorVoiceManager>
{
	// Token: 0x06000F35 RID: 3893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x1D55DE0", Offset = "0x1D55EE1", VA = "0x1D55DE0")]
	private void Start()
	{
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x1D55E00", Offset = "0x1D55F01", VA = "0x1D55E00")]
	private void Update()
	{
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x1D55DF0", Offset = "0x1D55EF1", VA = "0x1D55DF0")]
	public void ResetTimeCount()
	{
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x00006CD8 File Offset: 0x00004ED8
	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x1D55FD0", Offset = "0x1D560D1", VA = "0x1D55FD0")]
	public bool Regist(ActorController actorController, ActorVoiceController charaVoiceController)
	{
		return default(bool);
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0x1D56040", Offset = "0x1D56141", VA = "0x1D56040")]
	public void Remove(ActorController actorController)
	{
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0x1D560B0", Offset = "0x1D561B1", VA = "0x1D560B0")]
	public ActorVoiceController Get(ActorController actorController)
	{
		return null;
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x00006CF0 File Offset: 0x00004EF0
	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x1D55E40", Offset = "0x1D55F41", VA = "0x1D55E40")]
	private bool CanPlayVoice()
	{
		return default(bool);
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x00006D08 File Offset: 0x00004F08
	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x1D56160", Offset = "0x1D56261", VA = "0x1D56160")]
	public bool PlayVoice(ActorController actorController, SoundID soundID)
	{
		return default(bool);
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x00006D20 File Offset: 0x00004F20
	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x1D56290", Offset = "0x1D56391", VA = "0x1D56290")]
	public bool PlayVoice(ActorID actorID, SoundID soundID)
	{
		return default(bool);
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00006D38 File Offset: 0x00004F38
	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x1D563E0", Offset = "0x1D564E1", VA = "0x1D563E0")]
	public bool PlayGroupVoice(ActorController actorController, VoiceGroup voiceGroup)
	{
		return default(bool);
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00006D50 File Offset: 0x00004F50
	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x1D56510", Offset = "0x1D56611", VA = "0x1D56510")]
	public bool PlayGroupVoice(ActorID actorID, VoiceGroup voiceGroup)
	{
		return default(bool);
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x1D56660", Offset = "0x1D56761", VA = "0x1D56660")]
	public void OnHit(ActorController actorController, StatusBase status, DamageResult damageResult)
	{
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x1D56670", Offset = "0x1D56771", VA = "0x1D56670")]
	public void OnDamage(ActorController actorController, StatusBase status, DamageResult damageResult)
	{
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x1D566D0", Offset = "0x1D567D1", VA = "0x1D566D0")]
	public void OnHeal(ActorController actorController)
	{
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x1D566E0", Offset = "0x1D567E1", VA = "0x1D566E0")]
	public void OnLockon(ActorController actorController, CharacterBase characterBase)
	{
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x1D566F0", Offset = "0x1D567F1", VA = "0x1D566F0")]
	public void OnDestroyTreasureBox(ActorController actorController)
	{
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x1D56700", Offset = "0x1D56801", VA = "0x1D56700")]
	public void OnDestroyGate(ActorController actorController)
	{
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x1D56710", Offset = "0x1D56811", VA = "0x1D56710")]
	public void OnItemGet(ActorController actorController, ItemData itemData)
	{
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x1D56720", Offset = "0x1D56821", VA = "0x1D56720")]
	public void OnItemUse(ActorController actorController, ItemData itemData)
	{
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x1D56730", Offset = "0x1D56831", VA = "0x1D56730")]
	public void OnItemThrow(ActorController actorController)
	{
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x1D56740", Offset = "0x1D56841", VA = "0x1D56740")]
	public void OnGreeting(ActorController actorController)
	{
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x1D56860", Offset = "0x1D56961", VA = "0x1D56860")]
	public ActorVoiceManager()
	{
	}

	// Token: 0x040008C8 RID: 2248
	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x18")]
	private Register<ActorController, ActorVoiceController> m_Register;

	// Token: 0x040008C9 RID: 2249
	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0x20")]
	private readonly float m_voicePlayableTime;

	// Token: 0x040008CA RID: 2250
	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x24")]
	private float m_elapsed;
}
