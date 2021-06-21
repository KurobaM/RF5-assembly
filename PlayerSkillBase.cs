using System;
using Il2CppDummyDll;

// Token: 0x02000A24 RID: 2596
[Token(Token = "0x20006CF")]
public class PlayerSkillBase
{
	// Token: 0x1700093B RID: 2363
	// (get) Token: 0x060043F0 RID: 17392 RVA: 0x00016AA0 File Offset: 0x00014CA0
	[Token(Token = "0x17000767")]
	public int lvMax
	{
		[Token(Token = "0x60038DC")]
		[Address(RVA = "0x24979F0", Offset = "0x2497AF1", VA = "0x24979F0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700093C RID: 2364
	// (get) Token: 0x060043F1 RID: 17393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000768")]
	public string name
	{
		[Token(Token = "0x60038DD")]
		[Address(RVA = "0x2497A00", Offset = "0x2497B01", VA = "0x2497A00")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700093D RID: 2365
	// (get) Token: 0x060043F2 RID: 17394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000769")]
	public string discription
	{
		[Token(Token = "0x60038DE")]
		[Address(RVA = "0x2497B00", Offset = "0x2497C01", VA = "0x2497B00")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700093E RID: 2366
	// (get) Token: 0x060043F3 RID: 17395 RVA: 0x00016AB8 File Offset: 0x00014CB8
	// (set) Token: 0x060043F4 RID: 17396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700076A")]
	public int SkillNo
	{
		[Token(Token = "0x60038DF")]
		[Address(RVA = "0x2497C00", Offset = "0x2497D01", VA = "0x2497C00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A77A0", Offset = "0x1A78A1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60038E0")]
		[Address(RVA = "0x2497C10", Offset = "0x2497D11", VA = "0x2497C10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A77B0", Offset = "0x1A78B1")]
		private set
		{
		}
	}

	// Token: 0x1700093F RID: 2367
	// (get) Token: 0x060043F5 RID: 17397 RVA: 0x00016AD0 File Offset: 0x00014CD0
	[Token(Token = "0x1700076B")]
	public int nowLv
	{
		[Token(Token = "0x60038E1")]
		[Address(RVA = "0x2497C20", Offset = "0x2497D21", VA = "0x2497C20")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000940 RID: 2368
	// (get) Token: 0x060043F6 RID: 17398 RVA: 0x00016AE8 File Offset: 0x00014CE8
	[Token(Token = "0x1700076C")]
	public int nowExpPercent
	{
		[Token(Token = "0x60038E2")]
		[Address(RVA = "0x2497C30", Offset = "0x2497D31", VA = "0x2497C30")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060043F7 RID: 17399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038E3")]
	[Address(RVA = "0x2497C80", Offset = "0x2497D81", VA = "0x2497C80")]
	public PlayerSkillBase(int skillNo)
	{
	}

	// Token: 0x0400A2E9 RID: 41705
	[Token(Token = "0x4007B1E")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x171D40", Offset = "0x171E41")]
	private int <SkillNo>k__BackingField;
}
