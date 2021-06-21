using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPhysics
{
	// Token: 0x020013D9 RID: 5081
	[Token(Token = "0x2000DA4")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150E90", Offset = "0x150F91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150E90", Offset = "0x150F91")]
	public class Raycast : Action
	{
		// Token: 0x060075FF RID: 30207 RVA: 0x00028ED8 File Offset: 0x000270D8
		[Token(Token = "0x60062B3")]
		[Address(RVA = "0x298C430", Offset = "0x298C531", VA = "0x298C430", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007600 RID: 30208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B4")]
		[Address(RVA = "0x298C710", Offset = "0x298C811", VA = "0x298C710", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B5")]
		[Address(RVA = "0x298C7F0", Offset = "0x298C8F1", VA = "0x298C7F0")]
		public Raycast()
		{
		}

		// Token: 0x0401B8C3 RID: 112835
		[Token(Token = "0x40182E4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BCB0", Offset = "0x18BDB1")]
		public SharedGameObject originGameObject;

		// Token: 0x0401B8C4 RID: 112836
		[Token(Token = "0x40182E5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BCF0", Offset = "0x18BDF1")]
		public SharedVector3 originPosition;

		// Token: 0x0401B8C5 RID: 112837
		[Token(Token = "0x40182E6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BD30", Offset = "0x18BE31")]
		public SharedVector3 direction;

		// Token: 0x0401B8C6 RID: 112838
		[Token(Token = "0x40182E7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BD70", Offset = "0x18BE71")]
		public SharedFloat distance;

		// Token: 0x0401B8C7 RID: 112839
		[Token(Token = "0x40182E8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BDB0", Offset = "0x18BEB1")]
		public LayerMask layerMask;

		// Token: 0x0401B8C8 RID: 112840
		[Token(Token = "0x40182E9")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BDF0", Offset = "0x18BEF1")]
		public Space space;

		// Token: 0x0401B8C9 RID: 112841
		[Token(Token = "0x40182EA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18BE30", Offset = "0x18BF31")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BE30", Offset = "0x18BF31")]
		public SharedGameObject storeHitObject;

		// Token: 0x0401B8CA RID: 112842
		[Token(Token = "0x40182EB")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18BE80", Offset = "0x18BF81")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BE80", Offset = "0x18BF81")]
		public SharedVector3 storeHitPoint;

		// Token: 0x0401B8CB RID: 112843
		[Token(Token = "0x40182EC")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18BED0", Offset = "0x18BFD1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BED0", Offset = "0x18BFD1")]
		public SharedVector3 storeHitNormal;

		// Token: 0x0401B8CC RID: 112844
		[Token(Token = "0x40182ED")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18BF20", Offset = "0x18C021")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BF20", Offset = "0x18C021")]
		public SharedFloat storeHitDistance;
	}
}
