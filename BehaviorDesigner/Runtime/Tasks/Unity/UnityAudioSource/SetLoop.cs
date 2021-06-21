using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001492 RID: 5266
	[Token(Token = "0x2000E58")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155210", Offset = "0x155311")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155210", Offset = "0x155311")]
	public class SetLoop : Action
	{
		// Token: 0x06007893 RID: 30867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006547")]
		[Address(RVA = "0x28DCCC0", Offset = "0x28DCDC1", VA = "0x28DCCC0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x00029FD0 File Offset: 0x000281D0
		[Token(Token = "0x6006548")]
		[Address(RVA = "0x28DCDC0", Offset = "0x28DCEC1", VA = "0x28DCDC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006549")]
		[Address(RVA = "0x28DCEC0", Offset = "0x28DCFC1", VA = "0x28DCEC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654A")]
		[Address(RVA = "0x28DCF10", Offset = "0x28DD011", VA = "0x28DCF10")]
		public SetLoop()
		{
		}

		// Token: 0x0401BB4A RID: 113482
		[Token(Token = "0x4018548")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191EB0", Offset = "0x191FB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB4B RID: 113483
		[Token(Token = "0x4018549")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191EF0", Offset = "0x191FF1")]
		public SharedBool loop;

		// Token: 0x0401BB4C RID: 113484
		[Token(Token = "0x401854A")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB4D RID: 113485
		[Token(Token = "0x401854B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
