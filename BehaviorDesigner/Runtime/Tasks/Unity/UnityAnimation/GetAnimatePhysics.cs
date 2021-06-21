using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014C5 RID: 5317
	[Token(Token = "0x2000E88")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156410", Offset = "0x156511")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156410", Offset = "0x156511")]
	public class GetAnimatePhysics : Action
	{
		// Token: 0x0600796A RID: 31082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600660C")]
		[Address(RVA = "0x28D2E20", Offset = "0x28D2F21", VA = "0x28D2E20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x0002A498 File Offset: 0x00028698
		[Token(Token = "0x600660D")]
		[Address(RVA = "0x28D2F20", Offset = "0x28D3021", VA = "0x28D2F20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600660E")]
		[Address(RVA = "0x28D3020", Offset = "0x28D3121", VA = "0x28D3020", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600660F")]
		[Address(RVA = "0x28D3090", Offset = "0x28D3191", VA = "0x28D3090")]
		public GetAnimatePhysics()
		{
		}

		// Token: 0x0401BC36 RID: 113718
		[Token(Token = "0x4018628")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193ED0", Offset = "0x193FD1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC37 RID: 113719
		[Token(Token = "0x4018629")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193F10", Offset = "0x194011")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x193F10", Offset = "0x194011")]
		public SharedBool storeValue;

		// Token: 0x0401BC38 RID: 113720
		[Token(Token = "0x401862A")]
		[FieldOffset(Offset = "0x60")]
		private Animation animation;

		// Token: 0x0401BC39 RID: 113721
		[Token(Token = "0x401862B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
