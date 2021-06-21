using System;
using Il2CppDummyDll;

// Token: 0x02000290 RID: 656
[Token(Token = "0x2000209")]
public class SuperArmorManager : SingletonMonoBehaviour<SuperArmorManager>
{
	// Token: 0x060010D9 RID: 4313 RVA: 0x00007BC0 File Offset: 0x00005DC0
	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0x1FAB8E0", Offset = "0x1FAB9E1", VA = "0x1FAB8E0")]
	public bool Regist(Character chara, SuperArmorController controller)
	{
		return default(bool);
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00007BD8 File Offset: 0x00005DD8
	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0x1FAB950", Offset = "0x1FABA51", VA = "0x1FAB950")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0x1FAB9C0", Offset = "0x1FABAC1", VA = "0x1FAB9C0")]
	public SuperArmorController Get(Character chara)
	{
		return null;
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4D")]
	[Address(RVA = "0x1FABA70", Offset = "0x1FABB71", VA = "0x1FABA70")]
	private void Update()
	{
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x00007BF0 File Offset: 0x00005DF0
	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0x1FAB670", Offset = "0x1FAB771", VA = "0x1FAB670")]
	public bool DoPlay(Character chara, float duration)
	{
		return default(bool);
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x00007C08 File Offset: 0x00005E08
	[Token(Token = "0x6000F4F")]
	[Address(RVA = "0x1FABBD0", Offset = "0x1FABCD1", VA = "0x1FABBD0")]
	public bool DoStop(Character chara)
	{
		return default(bool);
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F50")]
	[Address(RVA = "0x1FABD00", Offset = "0x1FABE01", VA = "0x1FABD00")]
	public SuperArmorManager()
	{
	}

	// Token: 0x04000976 RID: 2422
	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x18")]
	private Register<Character, SuperArmorController> m_Register;
}
