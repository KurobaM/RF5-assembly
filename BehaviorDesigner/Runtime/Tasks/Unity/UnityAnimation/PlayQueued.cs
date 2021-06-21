using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014C8 RID: 5320
	[Token(Token = "0x2000E8B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156530", Offset = "0x156631")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156530", Offset = "0x156631")]
	public class PlayQueued : Action
	{
		// Token: 0x06007976 RID: 31094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006618")]
		[Address(RVA = "0x28D3640", Offset = "0x28D3741", VA = "0x28D3640", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x0002A4E0 File Offset: 0x000286E0
		[Token(Token = "0x6006619")]
		[Address(RVA = "0x28D3740", Offset = "0x28D3841", VA = "0x28D3740", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661A")]
		[Address(RVA = "0x28D3840", Offset = "0x28D3941", VA = "0x28D3840", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661B")]
		[Address(RVA = "0x28D38C0", Offset = "0x28D39C1", VA = "0x28D38C0")]
		public PlayQueued()
		{
		}

		// Token: 0x0401BC43 RID: 113731
		[Token(Token = "0x4018635")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1940A0", Offset = "0x1941A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC44 RID: 113732
		[Token(Token = "0x4018636")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1940E0", Offset = "0x1941E1")]
		public SharedString animationName;

		// Token: 0x0401BC45 RID: 113733
		[Token(Token = "0x4018637")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194120", Offset = "0x194221")]
		public QueueMode queue;

		// Token: 0x0401BC46 RID: 113734
		[Token(Token = "0x4018638")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194160", Offset = "0x194261")]
		public PlayMode playMode;

		// Token: 0x0401BC47 RID: 113735
		[Token(Token = "0x4018639")]
		[FieldOffset(Offset = "0x68")]
		private Animation animation;

		// Token: 0x0401BC48 RID: 113736
		[Token(Token = "0x401863A")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
