using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	// Token: 0x020014DA RID: 5338
	[Token(Token = "0x2000E9D")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156BF0", Offset = "0x156CF1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156BF0", Offset = "0x156CF1")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x156BF0", Offset = "0x156CF1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x156BF0", Offset = "0x156CF1")]
	public class RotateTowardsEx : Action
	{
		// Token: 0x060079B3 RID: 31155 RVA: 0x0002A690 File Offset: 0x00028890
		[Token(Token = "0x6006655")]
		[Address(RVA = "0x2216720", Offset = "0x2216821", VA = "0x2216720", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x0002A6A8 File Offset: 0x000288A8
		[Token(Token = "0x6006656")]
		[Address(RVA = "0x22168D0", Offset = "0x22169D1", VA = "0x22168D0")]
		private Quaternion Target()
		{
			return default(Quaternion);
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006657")]
		[Address(RVA = "0x2216AA0", Offset = "0x2216BA1", VA = "0x2216AA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006658")]
		[Address(RVA = "0x2216C90", Offset = "0x2216D91", VA = "0x2216C90")]
		public RotateTowardsEx()
		{
		}

		// Token: 0x0401BC70 RID: 113776
		[Token(Token = "0x4018662")]
		[FieldOffset(Offset = "0x50")]
		public SharedFloat rotationEpsilon;

		// Token: 0x0401BC71 RID: 113777
		[Token(Token = "0x4018663")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194880", Offset = "0x194981")]
		public SharedFloat maxLookAtRotationDelta;

		// Token: 0x0401BC72 RID: 113778
		[Token(Token = "0x4018664")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1948C0", Offset = "0x1949C1")]
		public SharedBool onlyY;

		// Token: 0x0401BC73 RID: 113779
		[Token(Token = "0x4018665")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194900", Offset = "0x194A01")]
		public SharedGameObject target;

		// Token: 0x0401BC74 RID: 113780
		[Token(Token = "0x4018666")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194940", Offset = "0x194A41")]
		public SharedVector3 targetPosition;
	}
}
