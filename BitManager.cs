using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x0200026B RID: 619
[Token(Token = "0x20001ED")]
public class BitManager : SingletonMonoBehaviour<BitManager>
{
	// Token: 0x170002DA RID: 730
	// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00006EA0 File Offset: 0x000050A0
	// (set) Token: 0x06000F60 RID: 3936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002B0")]
	public bool InitCompleted
	{
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x2454E90", Offset = "0x2454F91", VA = "0x2454E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C250", Offset = "0x19C351")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x2454EA0", Offset = "0x2454FA1", VA = "0x2454EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C260", Offset = "0x19C361")]
		private set
		{
		}
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00006EB8 File Offset: 0x000050B8
	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x2454EB0", Offset = "0x2454FB1", VA = "0x2454EB0")]
	public bool Regist(Character chara, BitController controller)
	{
		return default(bool);
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00006ED0 File Offset: 0x000050D0
	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x2454F20", Offset = "0x2455021", VA = "0x2454F20")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x2454F90", Offset = "0x2455091", VA = "0x2454F90")]
	public BitController Get(Character chara)
	{
		return null;
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x2455040", Offset = "0x2455141", VA = "0x2455040")]
	public void Init()
	{
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x24550F0", Offset = "0x24551F1", VA = "0x24550F0")]
	public void Remove()
	{
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x2455160", Offset = "0x2455261", VA = "0x2455160")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x24551D0", Offset = "0x24552D1", VA = "0x24551D0")]
	private void Update()
	{
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x24552F0", Offset = "0x24553F1", VA = "0x24552F0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00006EE8 File Offset: 0x000050E8
	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x2455410", Offset = "0x2455511", VA = "0x2455410")]
	public bool RentBit(out BitBase outBit)
	{
		return default(bool);
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00006F00 File Offset: 0x00005100
	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x2455570", Offset = "0x2455671", VA = "0x2455570")]
	public bool DoCall(Character chara, BitID bitID, int level)
	{
		return default(bool);
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00006F18 File Offset: 0x00005118
	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x24556A0", Offset = "0x24557A1", VA = "0x24556A0")]
	public bool DoRelease(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x24557D0", Offset = "0x24558D1", VA = "0x24557D0")]
	public BitManager()
	{
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x2455890", Offset = "0x2455991", VA = "0x2455890")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C270", Offset = "0x19C371")]
	private void <Init>b__10_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x040008CD RID: 2253
	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E7B0", Offset = "0x15E8B1")]
	private bool <InitCompleted>k__BackingField;

	// Token: 0x040008CE RID: 2254
	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int m_BitNum;

	// Token: 0x040008CF RID: 2255
	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x20")]
	private List<BitBase> m_Bits;

	// Token: 0x040008D0 RID: 2256
	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0x28")]
	private Register<Character, BitController> m_Register;
}
