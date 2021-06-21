using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPhysics
{
	// Token: 0x020013DA RID: 5082
	[Token(Token = "0x2000DA5")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150EF0", Offset = "0x150FF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150EF0", Offset = "0x150FF1")]
	public class SphereCast : Action
	{
		// Token: 0x06007602 RID: 30210 RVA: 0x00028EF0 File Offset: 0x000270F0
		[Token(Token = "0x60062B6")]
		[Address(RVA = "0x298C850", Offset = "0x298C951", VA = "0x298C850", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B7")]
		[Address(RVA = "0x298CB50", Offset = "0x298CC51", VA = "0x298CB50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B8")]
		[Address(RVA = "0x298CC50", Offset = "0x298CD51", VA = "0x298CC50")]
		public SphereCast()
		{
		}

		// Token: 0x0401B8CD RID: 112845
		[Token(Token = "0x40182EE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BF70", Offset = "0x18C071")]
		public SharedGameObject originGameObject;

		// Token: 0x0401B8CE RID: 112846
		[Token(Token = "0x40182EF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BFB0", Offset = "0x18C0B1")]
		public SharedVector3 originPosition;

		// Token: 0x0401B8CF RID: 112847
		[Token(Token = "0x40182F0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BFF0", Offset = "0x18C0F1")]
		public SharedFloat radius;

		// Token: 0x0401B8D0 RID: 112848
		[Token(Token = "0x40182F1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C030", Offset = "0x18C131")]
		public SharedVector3 direction;

		// Token: 0x0401B8D1 RID: 112849
		[Token(Token = "0x40182F2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C070", Offset = "0x18C171")]
		public SharedFloat distance;

		// Token: 0x0401B8D2 RID: 112850
		[Token(Token = "0x40182F3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C0B0", Offset = "0x18C1B1")]
		public LayerMask layerMask;

		// Token: 0x0401B8D3 RID: 112851
		[Token(Token = "0x40182F4")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C0F0", Offset = "0x18C1F1")]
		public Space space;

		// Token: 0x0401B8D4 RID: 112852
		[Token(Token = "0x40182F5")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18C130", Offset = "0x18C231")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C130", Offset = "0x18C231")]
		public SharedGameObject storeHitObject;

		// Token: 0x0401B8D5 RID: 112853
		[Token(Token = "0x40182F6")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18C180", Offset = "0x18C281")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C180", Offset = "0x18C281")]
		public SharedVector3 storeHitPoint;

		// Token: 0x0401B8D6 RID: 112854
		[Token(Token = "0x40182F7")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18C1D0", Offset = "0x18C2D1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C1D0", Offset = "0x18C2D1")]
		public SharedVector3 storeHitNormal;

		// Token: 0x0401B8D7 RID: 112855
		[Token(Token = "0x40182F8")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18C220", Offset = "0x18C321")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C220", Offset = "0x18C321")]
		public SharedFloat storeHitDistance;
	}
}
