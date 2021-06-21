using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D66 RID: 3430
	[Token(Token = "0x20008CF")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x1486C0", Offset = "0x1487C1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x1486C0", Offset = "0x1487C1")]
	public class InteractionTrigger : MonoBehaviour
	{
		// Token: 0x06005914 RID: 22804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E4")]
		[Address(RVA = "0x27C2FA0", Offset = "0x27C30A1", VA = "0x27C2FA0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB2E0", Offset = "0x1AB3E1")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E5")]
		[Address(RVA = "0x27C2FF0", Offset = "0x27C30F1", VA = "0x27C2FF0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB320", Offset = "0x1AB421")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E6")]
		[Address(RVA = "0x27C3040", Offset = "0x27C3141", VA = "0x27C3040")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB360", Offset = "0x1AB461")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E7")]
		[Address(RVA = "0x27C3090", Offset = "0x27C3191", VA = "0x27C3090")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB3A0", Offset = "0x1AB4A1")]
		private void SupportGroup()
		{
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E8")]
		[Address(RVA = "0x27C30E0", Offset = "0x27C31E1", VA = "0x27C30E0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB3E0", Offset = "0x1AB4E1")]
		private void ASThread()
		{
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E9")]
		[Address(RVA = "0x27C3130", Offset = "0x27C3231", VA = "0x27C3130")]
		private void Start()
		{
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x0001D508 File Offset: 0x0001B708
		[Token(Token = "0x60049EA")]
		[Address(RVA = "0x27C3140", Offset = "0x27C3241", VA = "0x27C3140")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return 0;
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049EB")]
		[Address(RVA = "0x27C35B0", Offset = "0x27C36B1", VA = "0x27C35B0")]
		public InteractionTrigger()
		{
		}

		// Token: 0x0400B85A RID: 47194
		[Token(Token = "0x4008A18")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B7A0", Offset = "0x17B8A1")]
		public InteractionTrigger.Range[] ranges;

		// Token: 0x02000D67 RID: 3431
		[Token(Token = "0x200140E")]
		[Serializable]
		public class CharacterPosition
		{
			// Token: 0x17000B64 RID: 2916
			// (get) Token: 0x0600591C RID: 22812 RVA: 0x0001D520 File Offset: 0x0001B720
			[Token(Token = "0x17000E35")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60079FA")]
				[Address(RVA = "0x27C3B40", Offset = "0x27C3C41", VA = "0x27C3B40")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x0600591D RID: 22813 RVA: 0x0001D538 File Offset: 0x0001B738
			[Token(Token = "0x17000E36")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60079FB")]
				[Address(RVA = "0x27C3B80", Offset = "0x27C3C81", VA = "0x27C3B80")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x0600591E RID: 22814 RVA: 0x0001D550 File Offset: 0x0001B750
			[Token(Token = "0x60079FC")]
			[Address(RVA = "0x27C3C80", Offset = "0x27C3D81", VA = "0x27C3C80")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			// Token: 0x0600591F RID: 22815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079FD")]
			[Address(RVA = "0x27C4300", Offset = "0x27C4401", VA = "0x27C4300")]
			public CharacterPosition()
			{
			}

			// Token: 0x0400B85B RID: 47195
			[Token(Token = "0x401BA76")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197AD0", Offset = "0x197BD1")]
			public bool use;

			// Token: 0x0400B85C RID: 47196
			[Token(Token = "0x401BA77")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197B10", Offset = "0x197C11")]
			public Vector2 offset;

			// Token: 0x0400B85D RID: 47197
			[Token(Token = "0x401BA78")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197B50", Offset = "0x197C51")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197B50", Offset = "0x197C51")]
			public float angleOffset;

			// Token: 0x0400B85E RID: 47198
			[Token(Token = "0x401BA79")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197BB0", Offset = "0x197CB1")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197BB0", Offset = "0x197CB1")]
			public float maxAngle;

			// Token: 0x0400B85F RID: 47199
			[Token(Token = "0x401BA7A")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197C10", Offset = "0x197D11")]
			public float radius;

			// Token: 0x0400B860 RID: 47200
			[Token(Token = "0x401BA7B")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197C50", Offset = "0x197D51")]
			public bool orbit;

			// Token: 0x0400B861 RID: 47201
			[Token(Token = "0x401BA7C")]
			[FieldOffset(Offset = "0x29")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197C90", Offset = "0x197D91")]
			public bool fixYAxis;
		}

		// Token: 0x02000D68 RID: 3432
		[Token(Token = "0x200140F")]
		[Serializable]
		public class CameraPosition
		{
			// Token: 0x06005920 RID: 22816 RVA: 0x0001D568 File Offset: 0x0001B768
			[Token(Token = "0x60079FE")]
			[Address(RVA = "0x27C3620", Offset = "0x27C3721", VA = "0x27C3620")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			// Token: 0x06005921 RID: 22817 RVA: 0x0001D580 File Offset: 0x0001B780
			[Token(Token = "0x60079FF")]
			[Address(RVA = "0x27C37D0", Offset = "0x27C38D1", VA = "0x27C37D0")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			// Token: 0x06005922 RID: 22818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A00")]
			[Address(RVA = "0x27C3AB0", Offset = "0x27C3BB1", VA = "0x27C3AB0")]
			public CameraPosition()
			{
			}

			// Token: 0x0400B862 RID: 47202
			[Token(Token = "0x401BA7D")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197CD0", Offset = "0x197DD1")]
			public Collider lookAtTarget;

			// Token: 0x0400B863 RID: 47203
			[Token(Token = "0x401BA7E")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197D10", Offset = "0x197E11")]
			public Vector3 direction;

			// Token: 0x0400B864 RID: 47204
			[Token(Token = "0x401BA7F")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197D50", Offset = "0x197E51")]
			public float maxDistance;

			// Token: 0x0400B865 RID: 47205
			[Token(Token = "0x401BA80")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197D90", Offset = "0x197E91")]
			[Attribute(Name = "RangeAttribute", RVA = "0x197D90", Offset = "0x197E91")]
			public float maxAngle;

			// Token: 0x0400B866 RID: 47206
			[Token(Token = "0x401BA81")]
			[FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197DF0", Offset = "0x197EF1")]
			public bool fixYAxis;
		}

		// Token: 0x02000D69 RID: 3433
		[Token(Token = "0x2001410")]
		[Serializable]
		public class Range
		{
			// Token: 0x06005923 RID: 22819 RVA: 0x0001D598 File Offset: 0x0001B798
			[Token(Token = "0x6007A01")]
			[Address(RVA = "0x27C3460", Offset = "0x27C3561", VA = "0x27C3460")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			// Token: 0x06005924 RID: 22820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A02")]
			[Address(RVA = "0x27C4320", Offset = "0x27C4421", VA = "0x27C4320")]
			public Range()
			{
			}

			// Token: 0x0400B867 RID: 47207
			[Token(Token = "0x401BA82")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "HideInInspector", RVA = "0x197E30", Offset = "0x197F31")]
			[SerializeField]
			public string name;

			// Token: 0x0400B868 RID: 47208
			[Token(Token = "0x401BA83")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "HideInInspector", RVA = "0x197E70", Offset = "0x197F71")]
			[SerializeField]
			public bool show;

			// Token: 0x0400B869 RID: 47209
			[Token(Token = "0x401BA84")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197EB0", Offset = "0x197FB1")]
			public InteractionTrigger.CharacterPosition characterPosition;

			// Token: 0x0400B86A RID: 47210
			[Token(Token = "0x401BA85")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197EF0", Offset = "0x197FF1")]
			public InteractionTrigger.CameraPosition cameraPosition;

			// Token: 0x0400B86B RID: 47211
			[Token(Token = "0x401BA86")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197F30", Offset = "0x198031")]
			public InteractionTrigger.Range.Interaction[] interactions;

			// Token: 0x02000D6A RID: 3434
			[Token(Token = "0x200165C")]
			[Serializable]
			public class Interaction
			{
				// Token: 0x06005925 RID: 22821 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080BD")]
				[Address(RVA = "0x27C4330", Offset = "0x27C4431", VA = "0x27C4330")]
				public Interaction()
				{
				}

				// Token: 0x0400B86C RID: 47212
				[Token(Token = "0x401C42F")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x1996A0", Offset = "0x1997A1")]
				public InteractionObject interactionObject;

				// Token: 0x0400B86D RID: 47213
				[Token(Token = "0x401C430")]
				[FieldOffset(Offset = "0x18")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x1996E0", Offset = "0x1997E1")]
				public FullBodyBipedEffector[] effectors;
			}
		}
	}
}
