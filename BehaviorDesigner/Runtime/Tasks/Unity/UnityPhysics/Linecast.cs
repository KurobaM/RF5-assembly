using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPhysics
{
	// Token: 0x020013D8 RID: 5080
	[Token(Token = "0x2000DA3")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150E30", Offset = "0x150F31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150E30", Offset = "0x150F31")]
	public class Linecast : Action
	{
		// Token: 0x060075FC RID: 30204 RVA: 0x00028EC0 File Offset: 0x000270C0
		[Token(Token = "0x60062B0")]
		[Address(RVA = "0x298C260", Offset = "0x298C361", VA = "0x298C260", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B1")]
		[Address(RVA = "0x298C340", Offset = "0x298C441", VA = "0x298C340", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B2")]
		[Address(RVA = "0x298C3F0", Offset = "0x298C4F1", VA = "0x298C3F0")]
		public Linecast()
		{
		}

		// Token: 0x0401B8C0 RID: 112832
		[Token(Token = "0x40182E1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BBF0", Offset = "0x18BCF1")]
		public SharedVector3 startPosition;

		// Token: 0x0401B8C1 RID: 112833
		[Token(Token = "0x40182E2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BC30", Offset = "0x18BD31")]
		public SharedVector3 endPosition;

		// Token: 0x0401B8C2 RID: 112834
		[Token(Token = "0x40182E3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BC70", Offset = "0x18BD71")]
		public LayerMask layerMask;
	}
}
