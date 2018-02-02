<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_0acfe6e0d74ca654a1a4affc281db3f3a85b89e0dc74c98b09bfaf6fb7b9bf4c extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_2b8343f934ee93df0a64c9ac465045b7978c9c2200d76c6ac81ecdb3440b15c8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2b8343f934ee93df0a64c9ac465045b7978c9c2200d76c6ac81ecdb3440b15c8->enter($__internal_2b8343f934ee93df0a64c9ac465045b7978c9c2200d76c6ac81ecdb3440b15c8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_47334421a3ccc62ab7abeea4b4482df027266bb951b281bc0deed93254a6ed50 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_47334421a3ccc62ab7abeea4b4482df027266bb951b281bc0deed93254a6ed50->enter($__internal_47334421a3ccc62ab7abeea4b4482df027266bb951b281bc0deed93254a6ed50_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_2b8343f934ee93df0a64c9ac465045b7978c9c2200d76c6ac81ecdb3440b15c8->leave($__internal_2b8343f934ee93df0a64c9ac465045b7978c9c2200d76c6ac81ecdb3440b15c8_prof);

        
        $__internal_47334421a3ccc62ab7abeea4b4482df027266bb951b281bc0deed93254a6ed50->leave($__internal_47334421a3ccc62ab7abeea4b4482df027266bb951b281bc0deed93254a6ed50_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_140312bb6e960678e06bb3c5cd47b2e07eb175f7235a2d31cb5eac24bfab759a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_140312bb6e960678e06bb3c5cd47b2e07eb175f7235a2d31cb5eac24bfab759a->enter($__internal_140312bb6e960678e06bb3c5cd47b2e07eb175f7235a2d31cb5eac24bfab759a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_fbdb6846e93d6de96c19aaa9208006f2503c48e96be04604c020d5d11fa2b58f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fbdb6846e93d6de96c19aaa9208006f2503c48e96be04604c020d5d11fa2b58f->enter($__internal_fbdb6846e93d6de96c19aaa9208006f2503c48e96be04604c020d5d11fa2b58f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_fbdb6846e93d6de96c19aaa9208006f2503c48e96be04604c020d5d11fa2b58f->leave($__internal_fbdb6846e93d6de96c19aaa9208006f2503c48e96be04604c020d5d11fa2b58f_prof);

        
        $__internal_140312bb6e960678e06bb3c5cd47b2e07eb175f7235a2d31cb5eac24bfab759a->leave($__internal_140312bb6e960678e06bb3c5cd47b2e07eb175f7235a2d31cb5eac24bfab759a_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_ca20334c8d8381c4ecef86f2df7a55431b2b7f3c4e4bf07c1ac987230a486732 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ca20334c8d8381c4ecef86f2df7a55431b2b7f3c4e4bf07c1ac987230a486732->enter($__internal_ca20334c8d8381c4ecef86f2df7a55431b2b7f3c4e4bf07c1ac987230a486732_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_2d6d79778ff653992a95c03a327268e621fff445143dc61e5cad7c8250da8780 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2d6d79778ff653992a95c03a327268e621fff445143dc61e5cad7c8250da8780->enter($__internal_2d6d79778ff653992a95c03a327268e621fff445143dc61e5cad7c8250da8780_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_2d6d79778ff653992a95c03a327268e621fff445143dc61e5cad7c8250da8780->leave($__internal_2d6d79778ff653992a95c03a327268e621fff445143dc61e5cad7c8250da8780_prof);

        
        $__internal_ca20334c8d8381c4ecef86f2df7a55431b2b7f3c4e4bf07c1ac987230a486732->leave($__internal_ca20334c8d8381c4ecef86f2df7a55431b2b7f3c4e4bf07c1ac987230a486732_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_780426548a335f2ea7a3c126cfc4af51cb802ebad0cb0cddfdc46ee5597bd7be = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_780426548a335f2ea7a3c126cfc4af51cb802ebad0cb0cddfdc46ee5597bd7be->enter($__internal_780426548a335f2ea7a3c126cfc4af51cb802ebad0cb0cddfdc46ee5597bd7be_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_33ae80e87be8f926f1a1fca89e0834ae23a12647e461e1295361a98250e0f287 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_33ae80e87be8f926f1a1fca89e0834ae23a12647e461e1295361a98250e0f287->enter($__internal_33ae80e87be8f926f1a1fca89e0834ae23a12647e461e1295361a98250e0f287_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_33ae80e87be8f926f1a1fca89e0834ae23a12647e461e1295361a98250e0f287->leave($__internal_33ae80e87be8f926f1a1fca89e0834ae23a12647e461e1295361a98250e0f287_prof);

        
        $__internal_780426548a335f2ea7a3c126cfc4af51cb802ebad0cb0cddfdc46ee5597bd7be->leave($__internal_780426548a335f2ea7a3c126cfc4af51cb802ebad0cb0cddfdc46ee5597bd7be_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
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

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "C:\\Projects\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
