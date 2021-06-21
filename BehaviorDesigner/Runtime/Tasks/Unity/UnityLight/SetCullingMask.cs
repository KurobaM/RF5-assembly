using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x0200142D RID: 5165
	[Token(Token = "0x2000DF3")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152C30", Offset = "0x152D31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152C30", Offset = "0x152D31")]
	public class SetCullingMask : Action
	{
		// Token: 0x06007723 RID: 30499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D7")]
		[Address(RVA = "0x28E8450", Offset = "0x28E8551", VA = "0x28E8450", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x00029640 File Offset: 0x00027840
		[Token(Token = "0x60063D8")]
		[Address(RVA = "0x28E8550", Offset = "0x28E8651", VA = "0x28E8550", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D9")]
		[Address(RVA = "0x28E8640", Offset = "0x28E8741", VA = "0x28E8640", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DA")]
		[Address(RVA = "0x28E8680", Offset = "0x28E8781", VA = "0x28E8680")]
		public SetCullingMask()
		{
		}

		// Token: 0x0401BA05 RID: 113157
		[Token(Token = "0x4018403")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EA80", Offset = "0x18EB81")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA06 RID: 113158
		[Token(Token = "0x4018404")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EAC0", Offset = "0x18EBC1")]
		public LayerMask cullingMask;

		// Token: 0x0401BA07 RID: 113159
		[Token(Token = "0x4018405")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA08 RID: 113160
		[Token(Token = "0x4018406")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
