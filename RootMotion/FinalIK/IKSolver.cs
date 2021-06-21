using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D34 RID: 3380
	[Token(Token = "0x20008B9")]
	[Serializable]
	public abstract class IKSolver
	{
		// Token: 0x060056D0 RID: 22224 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
		[Token(Token = "0x6004856")]
		[Address(RVA = "0x2C19FB0", Offset = "0x2C1A0B1", VA = "0x2C19FB0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060056D1 RID: 22225
		[Token(Token = "0x6004857")]
		public abstract bool IsValid(ref string message);

		// Token: 0x060056D2 RID: 22226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004858")]
		[Address(RVA = "0x2C017C0", Offset = "0x2C018C1", VA = "0x2C017C0")]
		public void Initiate(Transform root)
		{
		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004859")]
		[Address(RVA = "0x2C02280", Offset = "0x2C02381", VA = "0x2C02280")]
		public void Update()
		{
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x0001C908 File Offset: 0x0001AB08
		[Token(Token = "0x600485A")]
		[Address(RVA = "0x2C1A030", Offset = "0x2C1A131", VA = "0x2C1A030", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485B")]
		[Address(RVA = "0x2C1A040", Offset = "0x2C1A141", VA = "0x2C1A040")]
		public void SetIKPosition(Vector3 position)
		{
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x0001C920 File Offset: 0x0001AB20
		[Token(Token = "0x600485C")]
		[Address(RVA = "0x2C1A050", Offset = "0x2C1A151", VA = "0x2C1A050")]
		public float GetIKPositionWeight()
		{
			return 0f;
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485D")]
		[Address(RVA = "0x2C1A060", Offset = "0x2C1A161", VA = "0x2C1A060")]
		public void SetIKPositionWeight(float weight)
		{
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600485E")]
		[Address(RVA = "0x2C1A0F0", Offset = "0x2C1A1F1", VA = "0x2C1A0F0")]
		public Transform GetRoot()
		{
			return null;
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060056D9 RID: 22233 RVA: 0x0001C938 File Offset: 0x0001AB38
		// (set) Token: 0x060056DA RID: 22234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008BA")]
		public bool initiated
		{
			[Token(Token = "0x600485F")]
			[Address(RVA = "0x2C1A100", Offset = "0x2C1A201", VA = "0x2C1A100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AABC0", Offset = "0x1AACC1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004860")]
			[Address(RVA = "0x2C1A110", Offset = "0x2C1A211", VA = "0x2C1A110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AABD0", Offset = "0x1AACD1")]
			private set
			{
			}
		}

		// Token: 0x060056DB RID: 22235
		[Token(Token = "0x6004861")]
		public abstract IKSolver.Point[] GetPoints();

		// Token: 0x060056DC RID: 22236
		[Token(Token = "0x6004862")]
		public abstract IKSolver.Point GetPoint(Transform transform);

		// Token: 0x060056DD RID: 22237
		[Token(Token = "0x6004863")]
		public abstract void FixTransforms();

		// Token: 0x060056DE RID: 22238
		[Token(Token = "0x6004864")]
		public abstract void StoreDefaultLocalState();

		// Token: 0x060056DF RID: 22239
		[Token(Token = "0x6004865")]
		protected abstract void OnInitiate();

		// Token: 0x060056E0 RID: 22240
		[Token(Token = "0x6004866")]
		protected abstract void OnUpdate();

		// Token: 0x060056E1 RID: 22241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004867")]
		[Address(RVA = "0x2C1A120", Offset = "0x2C1A221", VA = "0x2C1A120")]
		protected void LogWarning(string message)
		{
		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004868")]
		[Address(RVA = "0x2C1A140", Offset = "0x2C1A241", VA = "0x2C1A140")]
		public static Transform ContainsDuplicateBone(IKSolver.Bone[] bones)
		{
			return null;
		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x0001C950 File Offset: 0x0001AB50
		[Token(Token = "0x6004869")]
		[Address(RVA = "0x2C1A280", Offset = "0x2C1A381", VA = "0x2C1A280")]
		public static bool HierarchyIsValid(IKSolver.Bone[] bones)
		{
			return default(bool);
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x0001C968 File Offset: 0x0001AB68
		[Token(Token = "0x600486A")]
		[Address(RVA = "0x2C1A330", Offset = "0x2C1A431", VA = "0x2C1A330")]
		protected static float PreSolveBones(ref IKSolver.Bone[] bones)
		{
			return 0f;
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486B")]
		[Address(RVA = "0x2C1A6D0", Offset = "0x2C1A7D1", VA = "0x2C1A6D0")]
		protected IKSolver()
		{
		}

		// Token: 0x0400B652 RID: 46674
		[Token(Token = "0x4008908")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HideInInspector", RVA = "0x17A980", Offset = "0x17AA81")]
		public Vector3 IKPosition;

		// Token: 0x0400B653 RID: 46675
		[Token(Token = "0x4008909")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A990", Offset = "0x17AA91")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A990", Offset = "0x17AA91")]
		public float IKPositionWeight;

		// Token: 0x0400B654 RID: 46676
		[Token(Token = "0x400890A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17A9F0", Offset = "0x17AAF1")]
		private bool <initiated>k__BackingField;

		// Token: 0x0400B655 RID: 46677
		[Token(Token = "0x400890B")]
		[FieldOffset(Offset = "0x28")]
		public IKSolver.UpdateDelegate OnPreInitiate;

		// Token: 0x0400B656 RID: 46678
		[Token(Token = "0x400890C")]
		[FieldOffset(Offset = "0x30")]
		public IKSolver.UpdateDelegate OnPostInitiate;

		// Token: 0x0400B657 RID: 46679
		[Token(Token = "0x400890D")]
		[FieldOffset(Offset = "0x38")]
		public IKSolver.UpdateDelegate OnPreUpdate;

		// Token: 0x0400B658 RID: 46680
		[Token(Token = "0x400890E")]
		[FieldOffset(Offset = "0x40")]
		public IKSolver.UpdateDelegate OnPostUpdate;

		// Token: 0x0400B659 RID: 46681
		[Token(Token = "0x400890F")]
		[FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		// Token: 0x0400B65A RID: 46682
		[Token(Token = "0x4008910")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x17AA00", Offset = "0x17AB01")]
		protected Transform root;

		// Token: 0x02000D35 RID: 3381
		[Token(Token = "0x20013F4")]
		[Serializable]
		public class Point
		{
			// Token: 0x060056E6 RID: 22246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007944")]
			[Address(RVA = "0x256D960", Offset = "0x256DA61", VA = "0x256D960")]
			public void StoreDefaultLocalState()
			{
			}

			// Token: 0x060056E7 RID: 22247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007945")]
			[Address(RVA = "0x256D9C0", Offset = "0x256DAC1", VA = "0x256D9C0")]
			public void FixTransform()
			{
			}

			// Token: 0x060056E8 RID: 22248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007946")]
			[Address(RVA = "0x256DB50", Offset = "0x256DC51", VA = "0x256DB50")]
			public void UpdateSolverPosition()
			{
			}

			// Token: 0x060056E9 RID: 22249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007947")]
			[Address(RVA = "0x256DB90", Offset = "0x256DC91", VA = "0x256DB90")]
			public void UpdateSolverLocalPosition()
			{
			}

			// Token: 0x060056EA RID: 22250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007948")]
			[Address(RVA = "0x256DBD0", Offset = "0x256DCD1", VA = "0x256DBD0")]
			public void UpdateSolverState()
			{
			}

			// Token: 0x060056EB RID: 22251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007949")]
			[Address(RVA = "0x256DC30", Offset = "0x256DD31", VA = "0x256DC30")]
			public void UpdateSolverLocalState()
			{
			}

			// Token: 0x060056EC RID: 22252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600794A")]
			[Address(RVA = "0x256D160", Offset = "0x256D261", VA = "0x256D160")]
			public Point()
			{
			}

			// Token: 0x0400B65B RID: 46683
			[Token(Token = "0x401B98E")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x0400B65C RID: 46684
			[Token(Token = "0x401B98F")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "RangeAttribute", RVA = "0x196030", Offset = "0x196131")]
			public float weight;

			// Token: 0x0400B65D RID: 46685
			[Token(Token = "0x401B990")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			// Token: 0x0400B65E RID: 46686
			[Token(Token = "0x401B991")]
			[FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			// Token: 0x0400B65F RID: 46687
			[Token(Token = "0x401B992")]
			[FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			// Token: 0x0400B660 RID: 46688
			[Token(Token = "0x401B993")]
			[FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;
		}

		// Token: 0x02000D36 RID: 3382
		[Token(Token = "0x20013F5")]
		[Serializable]
		public class Bone : IKSolver.Point
		{
			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x060056ED RID: 22253 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060056EE RID: 22254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E14")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600794B")]
				[Address(RVA = "0x256C680", Offset = "0x256C781", VA = "0x256C680")]
				get
				{
					return null;
				}
				[Token(Token = "0x600794C")]
				[Address(RVA = "0x256C790", Offset = "0x256C891", VA = "0x256C790")]
				set
				{
				}
			}

			// Token: 0x060056EF RID: 22255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600794D")]
			[Address(RVA = "0x256C830", Offset = "0x256C931", VA = "0x256C830")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x060056F0 RID: 22256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600794E")]
			[Address(RVA = "0x256CAF0", Offset = "0x256CBF1", VA = "0x256CAF0")]
			public static void SolverSwing(IKSolver.Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x060056F1 RID: 22257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600794F")]
			[Address(RVA = "0x256CDD0", Offset = "0x256CED1", VA = "0x256CDD0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x060056F2 RID: 22258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007950")]
			[Address(RVA = "0x256D040", Offset = "0x256D141", VA = "0x256D040")]
			public void SetToSolverPosition()
			{
			}

			// Token: 0x060056F3 RID: 22259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007951")]
			[Address(RVA = "0x256D070", Offset = "0x256D171", VA = "0x256D070")]
			public Bone()
			{
			}

			// Token: 0x060056F4 RID: 22260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007952")]
			[Address(RVA = "0x256D1F0", Offset = "0x256D2F1", VA = "0x256D1F0")]
			public Bone(Transform transform)
			{
			}

			// Token: 0x060056F5 RID: 22261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007953")]
			[Address(RVA = "0x256D2F0", Offset = "0x256D3F1", VA = "0x256D2F0")]
			public Bone(Transform transform, float weight)
			{
			}

			// Token: 0x0400B661 RID: 46689
			[Token(Token = "0x401B994")]
			[FieldOffset(Offset = "0x54")]
			public float length;

			// Token: 0x0400B662 RID: 46690
			[Token(Token = "0x401B995")]
			[FieldOffset(Offset = "0x58")]
			public float sqrMag;

			// Token: 0x0400B663 RID: 46691
			[Token(Token = "0x401B996")]
			[FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			// Token: 0x0400B664 RID: 46692
			[Token(Token = "0x401B997")]
			[FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			// Token: 0x0400B665 RID: 46693
			[Token(Token = "0x401B998")]
			[FieldOffset(Offset = "0x70")]
			private bool isLimited;
		}

		// Token: 0x02000D37 RID: 3383
		[Token(Token = "0x20013F6")]
		[Serializable]
		public class Node : IKSolver.Point
		{
			// Token: 0x060056F6 RID: 22262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007954")]
			[Address(RVA = "0x256D770", Offset = "0x256D871", VA = "0x256D770")]
			public Node()
			{
			}

			// Token: 0x060056F7 RID: 22263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007955")]
			[Address(RVA = "0x256D800", Offset = "0x256D901", VA = "0x256D800")]
			public Node(Transform transform)
			{
			}

			// Token: 0x060056F8 RID: 22264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007956")]
			[Address(RVA = "0x256D8B0", Offset = "0x256D9B1", VA = "0x256D8B0")]
			public Node(Transform transform, float weight)
			{
			}

			// Token: 0x0400B666 RID: 46694
			[Token(Token = "0x401B999")]
			[FieldOffset(Offset = "0x54")]
			public float length;

			// Token: 0x0400B667 RID: 46695
			[Token(Token = "0x401B99A")]
			[FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			// Token: 0x0400B668 RID: 46696
			[Token(Token = "0x401B99B")]
			[FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			// Token: 0x0400B669 RID: 46697
			[Token(Token = "0x401B99C")]
			[FieldOffset(Offset = "0x60")]
			public Vector3 offset;
		}

		// Token: 0x02000D38 RID: 3384
		// (Invoke) Token: 0x060056FA RID: 22266
		[Token(Token = "0x20013F7")]
		public delegate void UpdateDelegate();

		// Token: 0x02000D39 RID: 3385
		// (Invoke) Token: 0x060056FE RID: 22270
		[Token(Token = "0x20013F8")]
		public delegate void IterationDelegate(int i);
	}
}
