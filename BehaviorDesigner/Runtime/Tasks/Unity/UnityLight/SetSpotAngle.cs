using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001433 RID: 5171
	[Token(Token = "0x2000DF9")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152E70", Offset = "0x152F71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152E70", Offset = "0x152F71")]
	public class SetSpotAngle : Action
	{
		// Token: 0x0600773B RID: 30523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EF")]
		[Address(RVA = "0x28E91D0", Offset = "0x28E92D1", VA = "0x28E91D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x000296D0 File Offset: 0x000278D0
		[Token(Token = "0x60063F0")]
		[Address(RVA = "0x28E92D0", Offset = "0x28E93D1", VA = "0x28E92D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F1")]
		[Address(RVA = "0x28E93C0", Offset = "0x28E94C1", VA = "0x28E93C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F2")]
		[Address(RVA = "0x28E9410", Offset = "0x28E9511", VA = "0x28E9410")]
		public SetSpotAngle()
		{
		}

		// Token: 0x0401BA1D RID: 113181
		[Token(Token = "0x401841B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18ED80", Offset = "0x18EE81")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA1E RID: 113182
		[Token(Token = "0x401841C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EDC0", Offset = "0x18EEC1")]
		public SharedFloat spotAngle;

		// Token: 0x0401BA1F RID: 113183
		[Token(Token = "0x401841D")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA20 RID: 113184
		[Token(Token = "0x401841E")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
