<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_9cc36d5ec5add1c3b58a73800826077a427f692a9c4bcd893e7730774ba78d70 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_6be339911b1809f6edea023796a6aec4b911ecd9bd65d13fb65fb1111f66450a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6be339911b1809f6edea023796a6aec4b911ecd9bd65d13fb65fb1111f66450a->enter($__internal_6be339911b1809f6edea023796a6aec4b911ecd9bd65d13fb65fb1111f66450a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_da70d1173422b5dda2bbf888f07c40ebf197e5bb1469b21827127046d08d1b80 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_da70d1173422b5dda2bbf888f07c40ebf197e5bb1469b21827127046d08d1b80->enter($__internal_da70d1173422b5dda2bbf888f07c40ebf197e5bb1469b21827127046d08d1b80_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_6be339911b1809f6edea023796a6aec4b911ecd9bd65d13fb65fb1111f66450a->leave($__internal_6be339911b1809f6edea023796a6aec4b911ecd9bd65d13fb65fb1111f66450a_prof);

        
        $__internal_da70d1173422b5dda2bbf888f07c40ebf197e5bb1469b21827127046d08d1b80->leave($__internal_da70d1173422b5dda2bbf888f07c40ebf197e5bb1469b21827127046d08d1b80_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_9cf45a07ac45fbb0e0044252ab8876d8fc9aaa49632b9d676bd660a62680b77b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_9cf45a07ac45fbb0e0044252ab8876d8fc9aaa49632b9d676bd660a62680b77b->enter($__internal_9cf45a07ac45fbb0e0044252ab8876d8fc9aaa49632b9d676bd660a62680b77b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_c2e0d1c670c4869254493563fbbae7df2d6b50ce1d0ca23a13384fa434688512 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c2e0d1c670c4869254493563fbbae7df2d6b50ce1d0ca23a13384fa434688512->enter($__internal_c2e0d1c670c4869254493563fbbae7df2d6b50ce1d0ca23a13384fa434688512_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_c2e0d1c670c4869254493563fbbae7df2d6b50ce1d0ca23a13384fa434688512->leave($__internal_c2e0d1c670c4869254493563fbbae7df2d6b50ce1d0ca23a13384fa434688512_prof);

        
        $__internal_9cf45a07ac45fbb0e0044252ab8876d8fc9aaa49632b9d676bd660a62680b77b->leave($__internal_9cf45a07ac45fbb0e0044252ab8876d8fc9aaa49632b9d676bd660a62680b77b_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_40492fe80e3aed2414d8950b45593176f1b6631a2ec524b13e5e0d9d46720df1 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_40492fe80e3aed2414d8950b45593176f1b6631a2ec524b13e5e0d9d46720df1->enter($__internal_40492fe80e3aed2414d8950b45593176f1b6631a2ec524b13e5e0d9d46720df1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_6f9b8675f648d2cfd292c9ec2517a3feac376a9bbd4ddf95498ae08e20161ac6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6f9b8675f648d2cfd292c9ec2517a3feac376a9bbd4ddf95498ae08e20161ac6->enter($__internal_6f9b8675f648d2cfd292c9ec2517a3feac376a9bbd4ddf95498ae08e20161ac6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_6f9b8675f648d2cfd292c9ec2517a3feac376a9bbd4ddf95498ae08e20161ac6->leave($__internal_6f9b8675f648d2cfd292c9ec2517a3feac376a9bbd4ddf95498ae08e20161ac6_prof);

        
        $__internal_40492fe80e3aed2414d8950b45593176f1b6631a2ec524b13e5e0d9d46720df1->leave($__internal_40492fe80e3aed2414d8950b45593176f1b6631a2ec524b13e5e0d9d46720df1_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_3974ff2f31d36f823a47cab0e431e2539469bf3b52b49e10dbae4963e93e6419 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3974ff2f31d36f823a47cab0e431e2539469bf3b52b49e10dbae4963e93e6419->enter($__internal_3974ff2f31d36f823a47cab0e431e2539469bf3b52b49e10dbae4963e93e6419_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_9928ce7c47e28f94f9a40813c4b77fab6d3f22b15a4014f0be8a4cdd053e2341 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9928ce7c47e28f94f9a40813c4b77fab6d3f22b15a4014f0be8a4cdd053e2341->enter($__internal_9928ce7c47e28f94f9a40813c4b77fab6d3f22b15a4014f0be8a4cdd053e2341_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_9928ce7c47e28f94f9a40813c4b77fab6d3f22b15a4014f0be8a4cdd053e2341->leave($__internal_9928ce7c47e28f94f9a40813c4b77fab6d3f22b15a4014f0be8a4cdd053e2341_prof);

        
        $__internal_3974ff2f31d36f823a47cab0e431e2539469bf3b52b49e10dbae4963e93e6419->leave($__internal_3974ff2f31d36f823a47cab0e431e2539469bf3b52b49e10dbae4963e93e6419_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "C:\\Projects\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
