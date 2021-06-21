using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020002FA RID: 762
[Token(Token = "0x200024E")]
public class ResourcesMng<T, Type> : SingletonMonoBehaviour<T> where T : MonoBehaviour where Type : UnityEngine.Object
{
	// Token: 0x0600142D RID: 5165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124C")]
	protected override void Awake()
	{
	}

	// Token: 0x0600142E RID: 5166 RVA: 0x00009138 File Offset: 0x00007338
	[Token(Token = "0x600124D")]
	private int GetEmptyIndex()
	{
		return 0;
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00009150 File Offset: 0x00007350
	[Token(Token = "0x600124E")]
	private int GetIndex(string name)
	{
		return 0;
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x00009168 File Offset: 0x00007368
	[Token(Token = "0x600124F")]
	public int GetOldIndex(int level)
	{
		return 0;
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x00009180 File Offset: 0x00007380
	[Token(Token = "0x6001250")]
	protected int SearchLoaded(string name, bool notCheckEnable = false)
	{
		return 0;
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001251")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CBF0", Offset = "0x19CCF1")]
	public IEnumerator LoadResource(string name, [Optional] Action<Type> onComp, int level = -1)
	{
		return null;
	}

	// Token: 0x1700038B RID: 907
	// (get) Token: 0x06001433 RID: 5171 RVA: 0x00009198 File Offset: 0x00007398
	[Token(Token = "0x17000351")]
	public virtual bool isLog
	{
		[Token(Token = "0x6001252")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001253")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CC60", Offset = "0x19CD61")]
	public IEnumerator GetOrLoadAsync(string name, [Optional] Action<Type> onComp, int level = -1)
	{
		return null;
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001254")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CCD0", Offset = "0x19CDD1")]
	protected IEnumerator LoadData(int index, string name, UnityAction<int> callback, int level = -1)
	{
		return null;
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001255")]
	protected void LoadData(int index, string name, Master id, UnityAction<int> callback, int level = -1)
	{
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001256")]
	protected virtual void ReleaseData(int index)
	{
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001257")]
	public virtual string GetResourcePath()
	{
		return null;
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001258")]
	public Type GetData(int index)
	{
		return null;
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001259")]
	public Type GetData(string name)
	{
		return null;
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125A")]
	public void AllRelease()
	{
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125B")]
	public void AllReleaseLevel(int level = -1)
	{
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125C")]
	public ResourcesMng()
	{
	}

	// Token: 0x04000B70 RID: 2928
	[Token(Token = "0x40008E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int WORK_MAX;

	// Token: 0x04000B71 RID: 2929
	[Token(Token = "0x40008E6")]
	public const int INDEX_EMPTY = -1;

	// Token: 0x04000B72 RID: 2930
	[Token(Token = "0x40008E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int m_baseLevel;

	// Token: 0x04000B73 RID: 2931
	[Token(Token = "0x40008E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected ResourcesMng<T, Type>.ResourcesWork[] m_pBuf;

	// Token: 0x04000B74 RID: 2932
	[Token(Token = "0x40008E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected string m_rootDirName;

	// Token: 0x04000B75 RID: 2933
	[Token(Token = "0x40008EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int logcounter;

	// Token: 0x020002FB RID: 763
	[Token(Token = "0x2001035")]
	public class ResourcesWork
	{
		// Token: 0x0600143F RID: 5183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCC")]
		public ResourcesWork()
		{
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCD")]
		public void SetData(Type data, string name, int level = -1, [Optional] AssetBundle bundle)
		{
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCE")]
		public void ClearData()
		{
		}

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4018EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Type m_data;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4018EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_enable;

		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4018F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_level;

		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4018F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_name;

		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4018F02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_loadTime;

		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4018F03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AssetBundle m_bundle;
	}

	// Token: 0x020002FC RID: 764
	[Token(Token = "0x2001036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1573E0", Offset = "0x1574E1")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x06001442 RID: 5186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCF")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD0")]
		internal void <LoadResource>b__0(int idx)
		{
		}

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4018F04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int index;
	}

	// Token: 0x020002FD RID: 765
	[Token(Token = "0x2001037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1573F0", Offset = "0x1574F1")]
	private sealed class <LoadResource>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001444 RID: 5188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD1")]
		[DebuggerHidden]
		public <LoadResource>d__11(int <>1__state)
		{
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD2")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x6006CD3")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF7")]
		private object Current
		{
			[Token(Token = "0x6006CD4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD5")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF8")]
		private object Current
		{
			[Token(Token = "0x6006CD6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4018F05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4018F06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4018F07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ResourcesMng<T, Type> <>4__this;

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4018F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4018F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int level;

		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4018F0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<Type> onComp;

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4018F0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ResourcesMng<T, Type>.<>c__DisplayClass11_0 <>8__1;
	}

	// Token: 0x020002FE RID: 766
	[Token(Token = "0x2001038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157400", Offset = "0x157501")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x0600144A RID: 5194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD7")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD8")]
		internal void <GetOrLoadAsync>b__0(int idx)
		{
		}

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4018F0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int index;
	}

	// Token: 0x020002FF RID: 767
	[Token(Token = "0x2001039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157410", Offset = "0x157511")]
	private sealed class <GetOrLoadAsync>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600144C RID: 5196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD9")]
		[DebuggerHidden]
		public <GetOrLoadAsync>d__15(int <>1__state)
		{
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDA")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x6006CDB")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF9")]
		private object Current
		{
			[Token(Token = "0x6006CDC")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDD")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFA")]
		private object Current
		{
			[Token(Token = "0x6006CDE")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4018F0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x04000B86 RID: 2950
		[Token(Token = "0x4018F0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		// Token: 0x04000B87 RID: 2951
		[Token(Token = "0x4018F0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ResourcesMng<T, Type> <>4__this;

		// Token: 0x04000B88 RID: 2952
		[Token(Token = "0x4018F10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4018F11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int level;

		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4018F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<Type> onComp;

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4018F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ResourcesMng<T, Type>.<>c__DisplayClass15_0 <>8__1;
	}

	// Token: 0x02000300 RID: 768
	[Token(Token = "0x200103A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157420", Offset = "0x157521")]
	private sealed class <LoadData>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001452 RID: 5202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDF")]
		[DebuggerHidden]
		public <LoadData>d__16(int <>1__state)
		{
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE0")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x6006CE1")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFB")]
		private object Current
		{
			[Token(Token = "0x6006CE2")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE3")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFC")]
		private object Current
		{
			[Token(Token = "0x6006CE4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4018F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4018F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		// Token: 0x04000B8E RID: 2958
		[Token(Token = "0x4018F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04000B8F RID: 2959
		[Token(Token = "0x4018F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ResourcesMng<T, Type> <>4__this;

		// Token: 0x04000B90 RID: 2960
		[Token(Token = "0x4018F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x04000B91 RID: 2961
		[Token(Token = "0x4018F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int level;

		// Token: 0x04000B92 RID: 2962
		[Token(Token = "0x4018F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UnityAction<int> callback;
	}

	// Token: 0x02000301 RID: 769
	[Token(Token = "0x200103B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157430", Offset = "0x157531")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06001458 RID: 5208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE5")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE6")]
		internal void <LoadData>b__0(AssetHandle<Type> handle)
		{
		}

		// Token: 0x04000B93 RID: 2963
		[Token(Token = "0x4018F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Type loadobject;

		// Token: 0x04000B94 RID: 2964
		[Token(Token = "0x4018F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ResourcesMng<T, Type> <>4__this;

		// Token: 0x04000B95 RID: 2965
		[Token(Token = "0x4018F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x04000B96 RID: 2966
		[Token(Token = "0x4018F1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4018F1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int level;

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4018F20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UnityAction<int> callback;
	}
}
