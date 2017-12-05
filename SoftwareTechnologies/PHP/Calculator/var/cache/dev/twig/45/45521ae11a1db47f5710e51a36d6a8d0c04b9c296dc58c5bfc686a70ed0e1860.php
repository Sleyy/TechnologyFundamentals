<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_ff42e28d3a6504b0321c4afca543674ac95ec5687a3a8639306c944ccbca89a4 extends Twig_Template
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
        $__internal_0eeabfc3ffa19fa67fc29dd060d5626bb58b077226595681b70ce48493be2bad = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0eeabfc3ffa19fa67fc29dd060d5626bb58b077226595681b70ce48493be2bad->enter($__internal_0eeabfc3ffa19fa67fc29dd060d5626bb58b077226595681b70ce48493be2bad_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_0eeabfc3ffa19fa67fc29dd060d5626bb58b077226595681b70ce48493be2bad->leave($__internal_0eeabfc3ffa19fa67fc29dd060d5626bb58b077226595681b70ce48493be2bad_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_88c7bb8ab3fced237c2aa8da7e61b0bc3f462baadd29815a56d1408169094551 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_88c7bb8ab3fced237c2aa8da7e61b0bc3f462baadd29815a56d1408169094551->enter($__internal_88c7bb8ab3fced237c2aa8da7e61b0bc3f462baadd29815a56d1408169094551_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_88c7bb8ab3fced237c2aa8da7e61b0bc3f462baadd29815a56d1408169094551->leave($__internal_88c7bb8ab3fced237c2aa8da7e61b0bc3f462baadd29815a56d1408169094551_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_d643bf3d31b1768789f2aaedea2a624ed1b1961bd7be14a572415b8c5bb36d88 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d643bf3d31b1768789f2aaedea2a624ed1b1961bd7be14a572415b8c5bb36d88->enter($__internal_d643bf3d31b1768789f2aaedea2a624ed1b1961bd7be14a572415b8c5bb36d88_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_d643bf3d31b1768789f2aaedea2a624ed1b1961bd7be14a572415b8c5bb36d88->leave($__internal_d643bf3d31b1768789f2aaedea2a624ed1b1961bd7be14a572415b8c5bb36d88_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_679b45f5a5f8106d37887dc86a9fe81f75f33fbad0f9d4d3878e9a6c04f2d3d7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_679b45f5a5f8106d37887dc86a9fe81f75f33fbad0f9d4d3878e9a6c04f2d3d7->enter($__internal_679b45f5a5f8106d37887dc86a9fe81f75f33fbad0f9d4d3878e9a6c04f2d3d7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_679b45f5a5f8106d37887dc86a9fe81f75f33fbad0f9d4d3878e9a6c04f2d3d7->leave($__internal_679b45f5a5f8106d37887dc86a9fe81f75f33fbad0f9d4d3878e9a6c04f2d3d7_prof);

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
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

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
";
    }
}
