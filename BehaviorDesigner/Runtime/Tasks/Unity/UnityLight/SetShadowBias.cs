using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001430 RID: 5168
	[Token(Token = "0x2000DF6")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152D50", Offset = "0x152E51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152D50", Offset = "0x152E51")]
	public class SetShadowBias : Action
	{
		// Token: 0x0600772F RID: 30511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E3")]
		[Address(RVA = "0x28E8B30", Offset = "0x28E8C31", VA = "0x28E8B30", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00029688 File Offset: 0x00027888
		[Token(Token = "0x60063E4")]
		[Address(RVA = "0x28E8C30", Offset = "0x28E8D31", VA = "0x28E8C30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E5")]
		[Address(RVA = "0x28E8D20", Offset = "0x28E8E21", VA = "0x28E8D20", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E6")]
		[Address(RVA = "0x28E8D70", Offset = "0x28E8E71", VA = "0x28E8D70")]
		public SetShadowBias()
		{
		}

		// Token: 0x0401BA11 RID: 113169
		[Token(Token = "0x401840F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EC00", Offset = "0x18ED01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA12 RID: 113170
		[Token(Token = "0x4018410")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EC40", Offset = "0x18ED41")]
		public SharedFloat shadowBias;

		// Token: 0x0401BA13 RID: 113171
		[Token(Token = "0x4018411")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA14 RID: 113172
		[Token(Token = "0x4018412")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
