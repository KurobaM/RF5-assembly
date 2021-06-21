using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013F0 RID: 5104
	[Token(Token = "0x2000DBB")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151730", Offset = "0x151831")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151730", Offset = "0x151831")]
	public class SetStartDelay : Action
	{
		// Token: 0x06007659 RID: 30297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630D")]
		[Address(RVA = "0x298AEF0", Offset = "0x298AFF1", VA = "0x298AEF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x00029100 File Offset: 0x00027300
		[Token(Token = "0x600630E")]
		[Address(RVA = "0x298AFF0", Offset = "0x298B0F1", VA = "0x298AFF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630F")]
		[Address(RVA = "0x298B120", Offset = "0x298B221", VA = "0x298B120", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006310")]
		[Address(RVA = "0x298B170", Offset = "0x298B271", VA = "0x298B170")]
		public SetStartDelay()
		{
		}

		// Token: 0x0401B925 RID: 112933
		[Token(Token = "0x4018346")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CBB0", Offset = "0x18CCB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B926 RID: 112934
		[Token(Token = "0x4018347")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CBF0", Offset = "0x18CCF1")]
		public SharedFloat startDelay;

		// Token: 0x0401B927 RID: 112935
		[Token(Token = "0x4018348")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B928 RID: 112936
		[Token(Token = "0x4018349")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
