using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnitySphereCollider
{
	// Token: 0x0200135B RID: 4955
	[Token(Token = "0x2000D26")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DF00", Offset = "0x14E001")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DF00", Offset = "0x14E001")]
	public class SetCenter : Action
	{
		// Token: 0x06007444 RID: 29764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F8")]
		[Address(RVA = "0x29991A0", Offset = "0x29992A1", VA = "0x29991A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x00028308 File Offset: 0x00026508
		[Token(Token = "0x60060F9")]
		[Address(RVA = "0x29992A0", Offset = "0x29993A1", VA = "0x29992A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FA")]
		[Address(RVA = "0x2999390", Offset = "0x2999491", VA = "0x2999390", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FB")]
		[Address(RVA = "0x2999420", Offset = "0x2999521", VA = "0x2999420")]
		public SetCenter()
		{
		}

		// Token: 0x0401B729 RID: 112425
		[Token(Token = "0x401814A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1872D0", Offset = "0x1873D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B72A RID: 112426
		[Token(Token = "0x401814B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187310", Offset = "0x187411")]
		public SharedVector3 center;

		// Token: 0x0401B72B RID: 112427
		[Token(Token = "0x401814C")]
		[FieldOffset(Offset = "0x60")]
		private SphereCollider sphereCollider;

		// Token: 0x0401B72C RID: 112428
		[Token(Token = "0x401814D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
