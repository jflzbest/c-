﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PDFView.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  使用此强类型资源类，为所有资源查找
        '''  重写当前线程的 CurrentUICulture 属性。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找类似 &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;PageIndex&lt;/TITLE&gt;
        '''&lt;SCRIPT LANGUAGE=&quot;JavaScript&quot;&gt;
        '''function changeImage(filename)
        '''{
        '''  parent.pageviewer.document.images[&apos;mainimage&apos;].src = filename;
        '''}
        '''&lt;/script&gt;
        '''&lt;/HEAD&gt;
        '''&lt;BODY bgcolor=&quot;#DDDDDD&quot;&gt;{Body}&lt;/BODY&gt;
        '''&lt;/HTML&gt; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property BookmarkHtml() As String
            Get
                Return ResourceManager.GetString("BookmarkHtml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;PDF to Image Html&lt;/TITLE&gt;
        '''&lt;/HEAD&gt;
        '''&lt;FRAMESET ROWS=&quot;50,*&quot; FRAMEBORDER=0 BORDER=0 &gt;
        '''                        &lt;FRAME NAME=&quot;top&quot; SRC=&quot;content/top.html&quot; MARGINHEIGHT=0 MARGINWIDTH=0 NORESIZE&gt;
        '''            &lt;FRAMESET COLS=&quot;20%,80%&quot; FRAMEBORDER=0 BORDER=0&gt;
        '''                        &lt;FRAME NAME=&quot;left&quot; SRC=&quot;content/bookmark.html&quot; MARGINHEIGHT=0 MARGINWIDTH=0 SCROLLING=AUTO NORESIZE&gt;
        '''                        &lt;FRAMESET ROWS=&quot;*,25&quot; FRAMEBORDER=0 BORDER=0 &gt;
        '''                        	&lt;FRAME NAME=&quot;pa [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property FrameHtml() As String
            Get
                Return ResourceManager.GetString("FrameHtml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;PageViewer&lt;/TITLE&gt;
        '''&lt;/HEAD&gt;
        '''&lt;BODY bgcolor=&quot;#999999&quot;&gt;&lt;center&gt;&lt;img id=&quot;mainimage&quot; src=&quot;images/page1.png&quot; width=&quot;100%&quot;&gt;&lt;/center&gt;&lt;/BODY&gt;
        '''&lt;/HTML&gt; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property PageHtml() As String
            Get
                Return ResourceManager.GetString("PageHtml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;PageSize&lt;/TITLE&gt;
        '''&lt;SCRIPT LANGUAGE=&quot;JavaScript&quot;&gt;
        '''function fitScreen()
        '''{
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.height = &apos;100%&apos;;
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.width = &apos;auto&apos;;
        '''}
        '''function fitWidth()
        '''{
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.height = &apos;auto&apos;;
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.width = &apos;100%&apos;;
        '''}
        '''function fitActual()
        '''{
        '''parent.pageviewer.document.images[&apos;mainimage&apos;].style.height = &apos;auto&apos;;
        '''parent [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property PagesizeHtml() As String
            Get
                Return ResourceManager.GetString("PagesizeHtml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 &lt;HTML&gt;
        '''&lt;HEAD&gt;
        '''&lt;TITLE&gt;DocumentName&lt;/TITLE&gt;
        '''&lt;/HEAD&gt;
        '''&lt;BODY bgcolor=&quot;#BBBBBB&quot;&gt;{DocumentName}&lt;/BODY&gt;
        '''&lt;/HTML&gt; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property TopHtml() As String
            Get
                Return ResourceManager.GetString("TopHtml", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
