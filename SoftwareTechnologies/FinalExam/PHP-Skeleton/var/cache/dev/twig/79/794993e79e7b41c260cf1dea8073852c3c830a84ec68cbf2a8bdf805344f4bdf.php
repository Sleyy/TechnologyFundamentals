<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_237ff2a1e63d63cd1d0c80b7dcb8957f3d313ef90d0e7788debff48edc841ff3 extends Twig_Template
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
        $__internal_4b8752112ca60ac88dc39b9fb5f9c2f74cad0c3aa26895ffbd58d07bd3dac82d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4b8752112ca60ac88dc39b9fb5f9c2f74cad0c3aa26895ffbd58d07bd3dac82d->enter($__internal_4b8752112ca60ac88dc39b9fb5f9c2f74cad0c3aa26895ffbd58d07bd3dac82d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $__internal_ebbe4edfc36de40075714189029e4ce5fd8537f65c0ff36822360d3ce7795eea = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ebbe4edfc36de40075714189029e4ce5fd8537f65c0ff36822360d3ce7795eea->enter($__internal_ebbe4edfc36de40075714189029e4ce5fd8537f65c0ff36822360d3ce7795eea_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_4b8752112ca60ac88dc39b9fb5f9c2f74cad0c3aa26895ffbd58d07bd3dac82d->leave($__internal_4b8752112ca60ac88dc39b9fb5f9c2f74cad0c3aa26895ffbd58d07bd3dac82d_prof);

        
        $__internal_ebbe4edfc36de40075714189029e4ce5fd8537f65c0ff36822360d3ce7795eea->leave($__internal_ebbe4edfc36de40075714189029e4ce5fd8537f65c0ff36822360d3ce7795eea_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_e3aa8f65f9c3181b26bd586f5723050e0cef4be71cf07bc55821622f31817ac0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e3aa8f65f9c3181b26bd586f5723050e0cef4be71cf07bc55821622f31817ac0->enter($__internal_e3aa8f65f9c3181b26bd586f5723050e0cef4be71cf07bc55821622f31817ac0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_506cd4ac9ae6efd49617012ed7c51e1e3dc7c875e95b27f99440ba05b89d8b35 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_506cd4ac9ae6efd49617012ed7c51e1e3dc7c875e95b27f99440ba05b89d8b35->enter($__internal_506cd4ac9ae6efd49617012ed7c51e1e3dc7c875e95b27f99440ba05b89d8b35_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <style>
        .sf-reset .traces {
            padding-bottom: 14px;
        }
        .sf-reset .traces li {
            font-size: 12px;
            color: #868686;
            padding: 5px 4px;
            list-style-type: decimal;
            margin-left: 20px;
        }
        .sf-reset #logs .traces li.error {
            font-style: normal;
            color: #AA3333;
            background: #f9ecec;
        }
        .sf-reset #logs .traces li.warning {
            font-style: normal;
            background: #ffcc00;
        }
        /* fix for Opera not liking empty <li> */
        .sf-reset .traces li:after {
            content: \"\\00A0\";
        }
        .sf-reset .trace {
            border: 1px solid #D3D3D3;
            padding: 10px;
            overflow: auto;
            margin: 10px 0 20px;
        }
        .sf-reset .block-exception {
            -moz-border-radius: 16px;
            -webkit-border-radius: 16px;
            border-radius: 16px;
            margin-bottom: 20px;
            background-color: #f6f6f6;
            border: 1px solid #dfdfdf;
            padding: 30px 28px;
            word-wrap: break-word;
            overflow: hidden;
        }
        .sf-reset .block-exception div {
            color: #313131;
            font-size: 10px;
        }
        .sf-reset .block-exception-detected .illustration-exception,
        .sf-reset .block-exception-detected .text-exception {
            float: left;
        }
        .sf-reset .block-exception-detected .illustration-exception {
            width: 152px;
        }
        .sf-reset .block-exception-detected .text-exception {
            width: 670px;
            padding: 30px 44px 24px 46px;
            position: relative;
        }
        .sf-reset .text-exception .open-quote,
        .sf-reset .text-exception .close-quote {
            font-family: Arial, Helvetica, sans-serif;
            position: absolute;
            color: #C9C9C9;
            font-size: 8em;
        }
        .sf-reset .open-quote {
            top: 0;
            left: 0;
        }
        .sf-reset .close-quote {
            bottom: -0.5em;
            right: 50px;
        }
        .sf-reset .block-exception p {
            font-family: Arial, Helvetica, sans-serif;
        }
        .sf-reset .block-exception p a,
        .sf-reset .block-exception p a:hover {
            color: #565656;
        }
        .sf-reset .logs h2 {
            float: left;
            width: 654px;
        }
        .sf-reset .error-count, .sf-reset .support {
            float: right;
            width: 170px;
            text-align: right;
        }
        .sf-reset .error-count span {
             display: inline-block;
             background-color: #aacd4e;
             -moz-border-radius: 6px;
             -webkit-border-radius: 6px;
             border-radius: 6px;
             padding: 4px;
             color: white;
             margin-right: 2px;
             font-size: 11px;
             font-weight: bold;
        }

        .sf-reset .support a {
            display: inline-block;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border-radius: 6px;
            padding: 4px;
            color: #000000;
            margin-right: 2px;
            font-size: 11px;
            font-weight: bold;
        }

        .sf-reset .toggle {
            vertical-align: middle;
        }
        .sf-reset .linked ul,
        .sf-reset .linked li {
            display: inline;
        }
        .sf-reset #output-content {
            color: #000;
            font-size: 12px;
        }
        .sf-reset #traces-text pre {
            white-space: pre;
            font-size: 12px;
            font-family: monospace;
        }
    </style>
";
        
        $__internal_506cd4ac9ae6efd49617012ed7c51e1e3dc7c875e95b27f99440ba05b89d8b35->leave($__internal_506cd4ac9ae6efd49617012ed7c51e1e3dc7c875e95b27f99440ba05b89d8b35_prof);

        
        $__internal_e3aa8f65f9c3181b26bd586f5723050e0cef4be71cf07bc55821622f31817ac0->leave($__internal_e3aa8f65f9c3181b26bd586f5723050e0cef4be71cf07bc55821622f31817ac0_prof);

    }

    // line 136
    public function block_title($context, array $blocks = array())
    {
        $__internal_1616e9a9e0d80806dd0e901502495b28fa10bdccf84971276a6c07c20930dfba = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1616e9a9e0d80806dd0e901502495b28fa10bdccf84971276a6c07c20930dfba->enter($__internal_1616e9a9e0d80806dd0e901502495b28fa10bdccf84971276a6c07c20930dfba_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_de54caf3672ca2b9dca7d070ff0ae3b19e9daf918a3f997d8a8b3faa1fea1d88 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_de54caf3672ca2b9dca7d070ff0ae3b19e9daf918a3f997d8a8b3faa1fea1d88->enter($__internal_de54caf3672ca2b9dca7d070ff0ae3b19e9daf918a3f997d8a8b3faa1fea1d88_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 137
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute(($context["exception"] ?? $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, ($context["status_code"] ?? $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, ($context["status_text"] ?? $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_de54caf3672ca2b9dca7d070ff0ae3b19e9daf918a3f997d8a8b3faa1fea1d88->leave($__internal_de54caf3672ca2b9dca7d070ff0ae3b19e9daf918a3f997d8a8b3faa1fea1d88_prof);

        
        $__internal_1616e9a9e0d80806dd0e901502495b28fa10bdccf84971276a6c07c20930dfba->leave($__internal_1616e9a9e0d80806dd0e901502495b28fa10bdccf84971276a6c07c20930dfba_prof);

    }

    // line 140
    public function block_body($context, array $blocks = array())
    {
        $__internal_6eb26e8a8a9b237c28ddac715571c247e45b26a9d61e793b48175e35a6be7c12 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6eb26e8a8a9b237c28ddac715571c247e45b26a9d61e793b48175e35a6be7c12->enter($__internal_6eb26e8a8a9b237c28ddac715571c247e45b26a9d61e793b48175e35a6be7c12_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_12abfd94d611fa466d45eb2d0f99ec3fbae506cf372f190ba9febb057c024609 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_12abfd94d611fa466d45eb2d0f99ec3fbae506cf372f190ba9febb057c024609->enter($__internal_12abfd94d611fa466d45eb2d0f99ec3fbae506cf372f190ba9febb057c024609_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 141
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 141)->display($context);
        
        $__internal_12abfd94d611fa466d45eb2d0f99ec3fbae506cf372f190ba9febb057c024609->leave($__internal_12abfd94d611fa466d45eb2d0f99ec3fbae506cf372f190ba9febb057c024609_prof);

        
        $__internal_6eb26e8a8a9b237c28ddac715571c247e45b26a9d61e793b48175e35a6be7c12->leave($__internal_6eb26e8a8a9b237c28ddac715571c247e45b26a9d61e793b48175e35a6be7c12_prof);

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
        return array (  226 => 141,  217 => 140,  200 => 137,  191 => 136,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <style>
        .sf-reset .traces {
            padding-bottom: 14px;
        }
        .sf-reset .traces li {
            font-size: 12px;
            color: #868686;
            padding: 5px 4px;
            list-style-type: decimal;
            margin-left: 20px;
        }
        .sf-reset #logs .traces li.error {
            font-style: normal;
            color: #AA3333;
            background: #f9ecec;
        }
        .sf-reset #logs .traces li.warning {
            font-style: normal;
            background: #ffcc00;
        }
        /* fix for Opera not liking empty <li> */
        .sf-reset .traces li:after {
            content: \"\\00A0\";
        }
        .sf-reset .trace {
            border: 1px solid #D3D3D3;
            padding: 10px;
            overflow: auto;
            margin: 10px 0 20px;
        }
        .sf-reset .block-exception {
            -moz-border-radius: 16px;
            -webkit-border-radius: 16px;
            border-radius: 16px;
            margin-bottom: 20px;
            background-color: #f6f6f6;
            border: 1px solid #dfdfdf;
            padding: 30px 28px;
            word-wrap: break-word;
            overflow: hidden;
        }
        .sf-reset .block-exception div {
            color: #313131;
            font-size: 10px;
        }
        .sf-reset .block-exception-detected .illustration-exception,
        .sf-reset .block-exception-detected .text-exception {
            float: left;
        }
        .sf-reset .block-exception-detected .illustration-exception {
            width: 152px;
        }
        .sf-reset .block-exception-detected .text-exception {
            width: 670px;
            padding: 30px 44px 24px 46px;
            position: relative;
        }
        .sf-reset .text-exception .open-quote,
        .sf-reset .text-exception .close-quote {
            font-family: Arial, Helvetica, sans-serif;
            position: absolute;
            color: #C9C9C9;
            font-size: 8em;
        }
        .sf-reset .open-quote {
            top: 0;
            left: 0;
        }
        .sf-reset .close-quote {
            bottom: -0.5em;
            right: 50px;
        }
        .sf-reset .block-exception p {
            font-family: Arial, Helvetica, sans-serif;
        }
        .sf-reset .block-exception p a,
        .sf-reset .block-exception p a:hover {
            color: #565656;
        }
        .sf-reset .logs h2 {
            float: left;
            width: 654px;
        }
        .sf-reset .error-count, .sf-reset .support {
            float: right;
            width: 170px;
            text-align: right;
        }
        .sf-reset .error-count span {
             display: inline-block;
             background-color: #aacd4e;
             -moz-border-radius: 6px;
             -webkit-border-radius: 6px;
             border-radius: 6px;
             padding: 4px;
             color: white;
             margin-right: 2px;
             font-size: 11px;
             font-weight: bold;
        }

        .sf-reset .support a {
            display: inline-block;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border-radius: 6px;
            padding: 4px;
            color: #000000;
            margin-right: 2px;
            font-size: 11px;
            font-weight: bold;
        }

        .sf-reset .toggle {
            vertical-align: middle;
        }
        .sf-reset .linked ul,
        .sf-reset .linked li {
            display: inline;
        }
        .sf-reset #output-content {
            color: #000;
            font-size: 12px;
        }
        .sf-reset #traces-text pre {
            white-space: pre;
            font-size: 12px;
            font-family: monospace;
        }
    </style>
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
", "@Twig/Exception/exception_full.html.twig", "C:\\Projects\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\Exception\\exception_full.html.twig");
    }
}
