using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D73 RID: 3443
	[Token(Token = "0x20008D4")]
	public abstract class RotationLimit : MonoBehaviour
	{
		// Token: 0x0600595E RID: 22878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A14")]
		[Address(RVA = "0x27CAC80", Offset = "0x27CAD81", VA = "0x27CAC80")]
		public void SetDefaultLocalRotation()
		{
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A15")]
		[Address(RVA = "0x27CACD0", Offset = "0x27CADD1", VA = "0x27CACD0")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		[Token(Token = "0x6004A16")]
		[Address(RVA = "0x27CACF0", Offset = "0x27CADF1", VA = "0x27CACF0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x0001D610 File Offset: 0x0001B810
		[Token(Token = "0x6004A17")]
		[Address(RVA = "0x27CAFC0", Offset = "0x27CB0C1", VA = "0x27CAFC0")]
		public bool Apply()
		{
			return default(bool);
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A18")]
		[Address(RVA = "0x27CB030", Offset = "0x27CB131", VA = "0x27CB030")]
		public void Disable()
		{
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x0001D628 File Offset: 0x0001B828
		[Token(Token = "0x170008EE")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6004A19")]
			[Address(RVA = "0x27CB070", Offset = "0x27CB171", VA = "0x27CB070")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06005964 RID: 22884 RVA: 0x0001D640 File Offset: 0x0001B840
		[Token(Token = "0x170008EF")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6004A1A")]
			[Address(RVA = "0x27CB0B0", Offset = "0x27CB1B1", VA = "0x27CB0B0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x0001D658 File Offset: 0x0001B858
		// (set) Token: 0x06005966 RID: 22886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F0")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6004A1B")]
			[Address(RVA = "0x27CB180", Offset = "0x27CB281", VA = "0x27CB180")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AB4D0", Offset = "0x1AB5D1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A1C")]
			[Address(RVA = "0x27CB190", Offset = "0x27CB291", VA = "0x27CB190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AB4E0", Offset = "0x1AB5E1")]
			private set
			{
			}
		}

		// Token: 0x06005967 RID: 22887
		[Token(Token = "0x6004A1D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		// Token: 0x06005968 RID: 22888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0x27CAEA0", Offset = "0x27CAFA1", VA = "0x27CAEA0")]
		private void Awake()
		{
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0x27CB1A0", Offset = "0x27CB2A1", VA = "0x27CB1A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A20")]
		[Address(RVA = "0x27CB1B0", Offset = "0x27CB2B1", VA = "0x27CB1B0")]
		public void LogWarning(string message)
		{
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x0001D670 File Offset: 0x0001B870
		[Token(Token = "0x6004A21")]
		[Address(RVA = "0x27CB280", Offset = "0x27CB381", VA = "0x27CB280")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x0001D688 File Offset: 0x0001B888
		[Token(Token = "0x6004A22")]
		[Address(RVA = "0x27CB370", Offset = "0x27CB471", VA = "0x27CB370")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
		[Token(Token = "0x6004A23")]
		[Address(RVA = "0x27CB5E0", Offset = "0x27CB6E1", VA = "0x27CB5E0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return 0f;
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A24")]
		[Address(RVA = "0x27CB6A0", Offset = "0x27CB7A1", VA = "0x27CB6A0")]
		protected RotationLimit()
		{
		}

		// Token: 0x0400B89E RID: 47262
		[Token(Token = "0x4008A34")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		// Token: 0x0400B89F RID: 47263
		[Token(Token = "0x4008A35")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "HideInInspector", RVA = "0x17B980", Offset = "0x17BA81")]
		public Quaternion defaultLocalRotation;

		// Token: 0x0400B8A0 RID: 47264
		[Token(Token = "0x4008A36")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17B990", Offset = "0x17BA91")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		// Token: 0x0400B8A1 RID: 47265
		[Token(Token = "0x4008A37")]
		[FieldOffset(Offset = "0x35")]
		private bool initiated;

		// Token: 0x0400B8A2 RID: 47266
		[Token(Token = "0x4008A38")]
		[FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		// Token: 0x0400B8A3 RID: 47267
		[Token(Token = "0x4008A39")]
		[FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;
	}
}
