using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010E RID: 270
[Token(Token = "0x20000D3")]
public class MonsterFootSteps : CharaFootSteps<MonsterControllerBase>
{
	// Token: 0x1700015A RID: 346
	// (get) Token: 0x060005D8 RID: 1496 RVA: 0x000041D0 File Offset: 0x000023D0
	[Token(Token = "0x17000154")]
	protected override FootStepType FootStepType
	{
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1E60E20", Offset = "0x1E60F21", VA = "0x1E60E20", Slot = "4")]
		get
		{
			return FootStepType.Human;
		}
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x1E60E30", Offset = "0x1E60F31", VA = "0x1E60E30")]
	public void Setup(MonsterDataTable monsterData, MonsterModel monsterModel, float parentLocalScaleX)
	{
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x1E60ED0", Offset = "0x1E60FD1", VA = "0x1E60ED0")]
	private void SetFootStepType(MonsterDataTable monsterData)
	{
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x1E60EE0", Offset = "0x1E60FE1", VA = "0x1E60EE0")]
	private void ResetTransform(MonsterModel monsterModel)
	{
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x000041E8 File Offset: 0x000023E8
	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x1E60FC0", Offset = "0x1E610C1", VA = "0x1E60FC0", Slot = "8")]
	protected override Vector3 GetRootPosition()
	{
		return default(Vector3);
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x1E61090", Offset = "0x1E61191", VA = "0x1E61090")]
	public MonsterFootSteps()
	{
	}

	// Token: 0x0400031D RID: 797
	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x60")]
	private FootStepType _FootStepType;

	// Token: 0x0400031E RID: 798
	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x68")]
	private Transform CenterTransform;
}
