using System;
using Il2CppDummyDll;

// Token: 0x02000269 RID: 617
[Token(Token = "0x20001EB")]
public class AvoidManager : SingletonMonoBehaviour<AvoidManager>
{
	// Token: 0x06000F4B RID: 3915 RVA: 0x00006D68 File Offset: 0x00004F68
	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x22997B0", Offset = "0x22998B1", VA = "0x22997B0")]
	public bool Regist(Character chara, AvoidController controller)
	{
		return default(bool);
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00006D80 File Offset: 0x00004F80
	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x2299820", Offset = "0x2299921", VA = "0x2299820")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x2299890", Offset = "0x2299991", VA = "0x2299890")]
	public AvoidController Get(Character chara)
	{
		return null;
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x2299940", Offset = "0x2299A41", VA = "0x2299940")]
	private void Update()
	{
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00006D98 File Offset: 0x00004F98
	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x2299A60", Offset = "0x2299B61", VA = "0x2299A60")]
	public bool CanPlay(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x00006DB0 File Offset: 0x00004FB0
	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x2299560", Offset = "0x2299661", VA = "0x2299560")]
	public bool DoPlay(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00006DC8 File Offset: 0x00004FC8
	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x2299B80", Offset = "0x2299C81", VA = "0x2299B80")]
	public bool DoStop(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x2299CB0", Offset = "0x2299DB1", VA = "0x2299CB0")]
	public void DoCancel(Character chara)
	{
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0x2299DD0", Offset = "0x2299ED1", VA = "0x2299DD0")]
	public void DoCancelAll()
	{
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00006DE0 File Offset: 0x00004FE0
	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0x2299EE0", Offset = "0x2299FE1", VA = "0x2299EE0")]
	public bool IsPlaying(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00006DF8 File Offset: 0x00004FF8
	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x229A000", Offset = "0x229A101", VA = "0x229A000")]
	public bool IsAnimation(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x229A120", Offset = "0x229A221", VA = "0x229A120")]
	public AvoidManager()
	{
	}

	// Token: 0x040008CB RID: 2251
	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x18")]
	private Register<Character, AvoidController> m_Register;
}
