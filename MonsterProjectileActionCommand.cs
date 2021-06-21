using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000099 RID: 153
[Token(Token = "0x2000076")]
public class MonsterProjectileActionCommand : MonsterActionBaseCommandBase
{
	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000073")]
	public virtual string NextActionCode
	{
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1E6E700", Offset = "0x1E6E801", VA = "0x1E6E700", Slot = "13")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060002F2 RID: 754 RVA: 0x00002EE0 File Offset: 0x000010E0
	[Token(Token = "0x17000074")]
	public virtual bool UseRotate
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1E6E720", Offset = "0x1E6E821", VA = "0x1E6E720", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060002F3 RID: 755 RVA: 0x00002EF8 File Offset: 0x000010F8
	[Token(Token = "0x17000075")]
	public virtual Vector2 DirectionBlurAngle
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1E6E740", Offset = "0x1E6E841", VA = "0x1E6E740", Slot = "15")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060002F4 RID: 756 RVA: 0x00002F10 File Offset: 0x00001110
	[Token(Token = "0x17000076")]
	public virtual float ChangeTargetDirectionAngle
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1E6E760", Offset = "0x1E6E861", VA = "0x1E6E760", Slot = "16")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x1E6E780", Offset = "0x1E6E881", VA = "0x1E6E780")]
	public MonsterProjectileActionCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsControllerBase controller)
	{
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1E6E7E0", Offset = "0x1E6E8E1", VA = "0x1E6E7E0", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x1E6E9B0", Offset = "0x1E6EAB1", VA = "0x1E6E9B0", Slot = "17")]
	protected virtual void ProjcticlePostprocess(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController)
	{
	}
}
