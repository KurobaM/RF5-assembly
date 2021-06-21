using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D64 RID: 3428
	[Token(Token = "0x20008CE")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148660", Offset = "0x148761")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148660", Offset = "0x148761")]
	public class InteractionTarget : MonoBehaviour
	{
		// Token: 0x06005907 RID: 22791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D8")]
		[Address(RVA = "0x2CE2890", Offset = "0x2CE2991", VA = "0x2CE2890")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB0E0", Offset = "0x1AB1E1")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D9")]
		[Address(RVA = "0x2CE28E0", Offset = "0x2CE29E1", VA = "0x2CE28E0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB120", Offset = "0x1AB221")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DA")]
		[Address(RVA = "0x2CE2930", Offset = "0x2CE2A31", VA = "0x2CE2930")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB160", Offset = "0x1AB261")]
		private void OpenTutorial1()
		{
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DB")]
		[Address(RVA = "0x2CE2980", Offset = "0x2CE2A81", VA = "0x2CE2980")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB1A0", Offset = "0x1AB2A1")]
		private void OpenTutorial2()
		{
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DC")]
		[Address(RVA = "0x2CE29D0", Offset = "0x2CE2AD1", VA = "0x2CE29D0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB1E0", Offset = "0x1AB2E1")]
		private void OpenTutorial3()
		{
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DD")]
		[Address(RVA = "0x2CE2A20", Offset = "0x2CE2B21", VA = "0x2CE2A20")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB220", Offset = "0x1AB321")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DE")]
		[Address(RVA = "0x2CE2A70", Offset = "0x2CE2B71", VA = "0x2CE2A70")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB260", Offset = "0x1AB361")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DF")]
		[Address(RVA = "0x2CE2AC0", Offset = "0x2CE2BC1", VA = "0x2CE2AC0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB2A0", Offset = "0x1AB3A1")]
		private void ASThread()
		{
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		[Token(Token = "0x60049E0")]
		[Address(RVA = "0x2CDD7C0", Offset = "0x2CDD8C1", VA = "0x2CDD7C0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return 0f;
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E1")]
		[Address(RVA = "0x2CDC570", Offset = "0x2CDC671", VA = "0x2CDC570")]
		public void ResetRotation()
		{
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E2")]
		[Address(RVA = "0x2CDA3C0", Offset = "0x2CDA4C1", VA = "0x2CDA3C0")]
		public void RotateTo(Vector3 position)
		{
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E3")]
		[Address(RVA = "0x2CE2B10", Offset = "0x2CE2C11", VA = "0x2CE2B10")]
		public InteractionTarget()
		{
		}

		// Token: 0x0400B84E RID: 47182
		[Token(Token = "0x4008A0E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B5A0", Offset = "0x17B6A1")]
		public FullBodyBipedEffector effectorType;

		// Token: 0x0400B84F RID: 47183
		[Token(Token = "0x4008A0F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B5E0", Offset = "0x17B6E1")]
		public InteractionTarget.Multiplier[] multipliers;

		// Token: 0x0400B850 RID: 47184
		[Token(Token = "0x4008A10")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B620", Offset = "0x17B721")]
		public float interactionSpeedMlp;

		// Token: 0x0400B851 RID: 47185
		[Token(Token = "0x4008A11")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B660", Offset = "0x17B761")]
		public Transform pivot;

		// Token: 0x0400B852 RID: 47186
		[Token(Token = "0x4008A12")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B6A0", Offset = "0x17B7A1")]
		public Vector3 twistAxis;

		// Token: 0x0400B853 RID: 47187
		[Token(Token = "0x4008A13")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B6E0", Offset = "0x17B7E1")]
		public float twistWeight;

		// Token: 0x0400B854 RID: 47188
		[Token(Token = "0x4008A14")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B720", Offset = "0x17B821")]
		public float swingWeight;

		// Token: 0x0400B855 RID: 47189
		[Token(Token = "0x4008A15")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B760", Offset = "0x17B861")]
		public bool rotateOnce;

		// Token: 0x0400B856 RID: 47190
		[Token(Token = "0x4008A16")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		// Token: 0x0400B857 RID: 47191
		[Token(Token = "0x4008A17")]
		[FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		// Token: 0x02000D65 RID: 3429
		[Token(Token = "0x200140D")]
		[Serializable]
		public class Multiplier
		{
			// Token: 0x06005913 RID: 22803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079F9")]
			[Address(RVA = "0x27C2F90", Offset = "0x27C3091", VA = "0x27C2F90")]
			public Multiplier()
			{
			}

			// Token: 0x0400B858 RID: 47192
			[Token(Token = "0x401BA74")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197A50", Offset = "0x197B51")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x0400B859 RID: 47193
			[Token(Token = "0x401BA75")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197A90", Offset = "0x197B91")]
			public float multiplier;
		}
	}
}
