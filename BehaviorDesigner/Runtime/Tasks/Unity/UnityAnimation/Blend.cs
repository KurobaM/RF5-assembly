using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014C2 RID: 5314
	[Token(Token = "0x2000E85")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1562F0", Offset = "0x1563F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1562F0", Offset = "0x1563F1")]
	public class Blend : Action
	{
		// Token: 0x0600795E RID: 31070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006600")]
		[Address(RVA = "0x28D2480", Offset = "0x28D2581", VA = "0x28D2480", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x0002A450 File Offset: 0x00028650
		[Token(Token = "0x6006601")]
		[Address(RVA = "0x28D2580", Offset = "0x28D2681", VA = "0x28D2580", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006602")]
		[Address(RVA = "0x28D2680", Offset = "0x28D2781", VA = "0x28D2680", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006603")]
		[Address(RVA = "0x28D2710", Offset = "0x28D2811", VA = "0x28D2710")]
		public Blend()
		{
		}

		// Token: 0x0401BC22 RID: 113698
		[Token(Token = "0x4018614")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193B50", Offset = "0x193C51")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC23 RID: 113699
		[Token(Token = "0x4018615")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193B90", Offset = "0x193C91")]
		public SharedString animationName;

		// Token: 0x0401BC24 RID: 113700
		[Token(Token = "0x4018616")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193BD0", Offset = "0x193CD1")]
		public float targetWeight;

		// Token: 0x0401BC25 RID: 113701
		[Token(Token = "0x4018617")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193C10", Offset = "0x193D11")]
		public float fadeLength;

		// Token: 0x0401BC26 RID: 113702
		[Token(Token = "0x4018618")]
		[FieldOffset(Offset = "0x68")]
		private Animation animation;

		// Token: 0x0401BC27 RID: 113703
		[Token(Token = "0x4018619")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
