<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_a32345c75285821de6c7d2a4d902d74f6461273ee0510309960802829777fc6d extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_9b54b643636714db72be0202d47d5a2af48115b6d3974eb2d28ce1327c01f669 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9b54b643636714db72be0202d47d5a2af48115b6d3974eb2d28ce1327c01f669->enter($__internal_9b54b643636714db72be0202d47d5a2af48115b6d3974eb2d28ce1327c01f669_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_9b54b643636714db72be0202d47d5a2af48115b6d3974eb2d28ce1327c01f669->leave($__internal_9b54b643636714db72be0202d47d5a2af48115b6d3974eb2d28ce1327c01f669_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_ceffc20969dbf469c6cb13b7cd10992f01d6edfea37e6d8fe70b4524c5aa9e8c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ceffc20969dbf469c6cb13b7cd10992f01d6edfea37e6d8fe70b4524c5aa9e8c->enter($__internal_ceffc20969dbf469c6cb13b7cd10992f01d6edfea37e6d8fe70b4524c5aa9e8c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_ceffc20969dbf469c6cb13b7cd10992f01d6edfea37e6d8fe70b4524c5aa9e8c->leave($__internal_ceffc20969dbf469c6cb13b7cd10992f01d6edfea37e6d8fe70b4524c5aa9e8c_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_9e94957b86a670574bb118f01b6c0e05c18276499f7973b856bb682ce45b3f9b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9e94957b86a670574bb118f01b6c0e05c18276499f7973b856bb682ce45b3f9b->enter($__internal_9e94957b86a670574bb118f01b6c0e05c18276499f7973b856bb682ce45b3f9b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_9e94957b86a670574bb118f01b6c0e05c18276499f7973b856bb682ce45b3f9b->leave($__internal_9e94957b86a670574bb118f01b6c0e05c18276499f7973b856bb682ce45b3f9b_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_7dfad6b5b3eb3e07f0576a5d7ad6c7e1019788624bce15e0c63f0f9b0867c3f4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7dfad6b5b3eb3e07f0576a5d7ad6c7e1019788624bce15e0c63f0f9b0867c3f4->enter($__internal_7dfad6b5b3eb3e07f0576a5d7ad6c7e1019788624bce15e0c63f0f9b0867c3f4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_7dfad6b5b3eb3e07f0576a5d7ad6c7e1019788624bce15e0c63f0f9b0867c3f4->leave($__internal_7dfad6b5b3eb3e07f0576a5d7ad6c7e1019788624bce15e0c63f0f9b0867c3f4_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
