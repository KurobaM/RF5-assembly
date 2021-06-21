using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x0200142E RID: 5166
	[Token(Token = "0x2000DF4")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152C90", Offset = "0x152D91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152C90", Offset = "0x152D91")]
	public class SetIntensity : Action
	{
		// Token: 0x06007727 RID: 30503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DB")]
		[Address(RVA = "0x28E8690", Offset = "0x28E8791", VA = "0x28E8690", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00029658 File Offset: 0x00027858
		[Token(Token = "0x60063DC")]
		[Address(RVA = "0x28E8790", Offset = "0x28E8891", VA = "0x28E8790", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DD")]
		[Address(RVA = "0x28E8880", Offset = "0x28E8981", VA = "0x28E8880", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DE")]
		[Address(RVA = "0x28E88D0", Offset = "0x28E89D1", VA = "0x28E88D0")]
		public SetIntensity()
		{
		}

		// Token: 0x0401BA09 RID: 113161
		[Token(Token = "0x4018407")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EB00", Offset = "0x18EC01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA0A RID: 113162
		[Token(Token = "0x4018408")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EB40", Offset = "0x18EC41")]
		public SharedFloat intensity;

		// Token: 0x0401BA0B RID: 113163
		[Token(Token = "0x4018409")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA0C RID: 113164
		[Token(Token = "0x401840A")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
