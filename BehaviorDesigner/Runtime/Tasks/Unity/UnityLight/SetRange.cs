using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x0200142F RID: 5167
	[Token(Token = "0x2000DF5")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152CF0", Offset = "0x152DF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152CF0", Offset = "0x152DF1")]
	public class SetRange : Action
	{
		// Token: 0x0600772B RID: 30507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DF")]
		[Address(RVA = "0x28E88E0", Offset = "0x28E89E1", VA = "0x28E88E0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00029670 File Offset: 0x00027870
		[Token(Token = "0x60063E0")]
		[Address(RVA = "0x28E89E0", Offset = "0x28E8AE1", VA = "0x28E89E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E1")]
		[Address(RVA = "0x28E8AD0", Offset = "0x28E8BD1", VA = "0x28E8AD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E2")]
		[Address(RVA = "0x28E8B20", Offset = "0x28E8C21", VA = "0x28E8B20")]
		public SetRange()
		{
		}

		// Token: 0x0401BA0D RID: 113165
		[Token(Token = "0x401840B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EB80", Offset = "0x18EC81")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA0E RID: 113166
		[Token(Token = "0x401840C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EBC0", Offset = "0x18ECC1")]
		public SharedFloat range;

		// Token: 0x0401BA0F RID: 113167
		[Token(Token = "0x401840D")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA10 RID: 113168
		[Token(Token = "0x401840E")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
